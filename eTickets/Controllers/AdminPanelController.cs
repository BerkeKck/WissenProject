using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using eTickets.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;
using eTickets.Models;
using eTickets.Entities.Model.Concrete;
using eTickets.BL.Managers.Abstract;
using eTickets.BL.Managers.Concrete;
using Microsoft.AspNetCore.Hosting;

namespace eTickets.Controllers
{

    public class AdminPanelController : Controller
    {
        private readonly IMovieManager _movieManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IActorManager _actorManager;
        private readonly IMovieActorManager _movieActorManager;
        private readonly IMovieCategoryManager _movieCategoryManager;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public AdminPanelController(IWebHostEnvironment webHostEnvironment, IMovieManager movieManager, ICategoryManager categoryManager, IMovieActorManager movieActorManager, IMovieCategoryManager movieCategoryManager, IActorManager actorManager)
        {
            _movieManager = movieManager;
            _categoryManager = categoryManager;
            _movieActorManager = movieActorManager;
            _movieCategoryManager = movieCategoryManager;
            _actorManager = actorManager;
            _webHostEnvironment = webHostEnvironment;
        }



        public async Task<IActionResult> CreateMovie()
        {
            CreateMovieViewModel model = new CreateMovieViewModel();
            ViewData["Actors"] = new SelectList(await _actorManager.GetAllAsync(), "Id", "ActorName");

            ViewData["Categories"] = new SelectList(await _categoryManager.GetAllAsync(), "Id", "CategoryName");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMovieViewModel model)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if (ModelState.IsValid)
            {
                var movie = new Movie
                {
                    MovieName = model.MovieName,
                    ReleaseDate = model.ReleaseDate,
                    Duration = model.Duration,
                    Description = model.Description,
                };
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.PhotoUrl.FileName);
                string productPath = Path.Combine(wwwRootPath, @"images/moviePhotos");
                using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                {
                    await model.PhotoUrl.CopyToAsync(fileStream);
                }
                movie.PhotoUrl = fileName;



                await _movieManager.InsertAsync(movie);
                // Add the movie to the database


                // Adding MovieActor relationships
                if (model.SelectedActorIds != null && model.SelectedActorIds.Any())
                {
                    foreach (var actorId in model.SelectedActorIds)
                    {
                        var movieActor = new MovieActor
                        {
                            MovieId = movie.Id,
                            ActorId = actorId
                        };

                        await _movieActorManager.InsertAsync(movieActor);
                    }
                }

                // Adding MovieCategory relationships
                if (model.SelectedCategoryIds != null && model.SelectedCategoryIds.Any())
                {
                    foreach (var categoryId in model.SelectedCategoryIds)
                    {
                        var movieCategory = new MovieCategory
                        {
                            MovieId = movie.Id,
                            CategoryId = categoryId
                        };

                        await _movieCategoryManager.InsertAsync(movieCategory);
                    }
                }

                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ViewData["Actors"] = new SelectList(await _actorManager.GetAllAsync(), "Id", "FullName");
            ViewData["Categories"] = new SelectList(await _categoryManager.GetAllAsync(), "Id", "Name"); return View(model);
        }
        // GET: AdminPanel/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _movieManager.GetByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: AdminPanel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _movieManager.GetByIdAsync(id);
            if (movie != null)
            {
                await _movieManager.DeleteAsync(id);
                return RedirectToAction(nameof(MovieList)); // Başarılıysa MovieList'e yönlendir
            }
            return NotFound(); // Film bulunamadıysa 404 döndür
        }
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _movieManager.GetByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            var model = new EditMovieViewModel
            {
                Id = movie.Id,
                MovieName = movie.MovieName,
                ReleaseDate = movie.ReleaseDate,
                Duration = movie.Duration,
                Description = movie.Description,
                PhotoUrl = movie.PhotoUrl,
                SelectedActorIds = movie.MovieActors?.Select(ma => ma.ActorId).ToList() ?? new List<int>(),
                SelectedCategoryIds = movie.MovieCategories?.Select(mc => mc.CategoryId).ToList() ?? new List<int>()
            };

            ViewData["Actors"] = new SelectList(await _actorManager.GetAllAsync(), "Id", "ActorName");
            ViewData["Categories"] = new SelectList(await _categoryManager.GetAllAsync(), "Id", "CategoryName");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditMovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                var movie = await _movieManager.GetByIdAsync(model.Id);
                if (movie == null)
                {
                    return NotFound();
                }
                // Film bilgilerini güncelle
                movie.MovieName = model.MovieName;
                movie.ReleaseDate = model.ReleaseDate;
                movie.Duration = (int)(double)model.Duration;
                movie.Description = model.Description;

                // Eğer yeni bir fotoğraf yüklenmişse, eski fotoğrafı silip yenisini kaydedin
                if (model.NewPhotoUrl != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.NewPhotoUrl.FileName);
                    string oldPhotoPath = Path.Combine(wwwRootPath, @"images/moviePhotos", movie.PhotoUrl);

                    if (System.IO.File.Exists(oldPhotoPath))
                    {
                        System.IO.File.Delete(oldPhotoPath);
                    }

                    using (var fileStream = new FileStream(Path.Combine(wwwRootPath, @"images/moviePhotos", fileName), FileMode.Create))
                    {
                        await model.NewPhotoUrl.CopyToAsync(fileStream);
                    }

                    movie.PhotoUrl = fileName;
                }
                // Yeni fotoğraf yüklenmemişse mevcut fotoğrafı koru

                await _movieManager.UpdateAsync(movie);


                return Json(new { success = true, message = "Edit Confirmed." });
            }
            // Model geçerli değilse, formu tekrar göster
            ViewData["Actors"] = new SelectList(await _actorManager.GetAllAsync(), "Id", "ActorName");
            ViewData["Categories"] = new SelectList(await _categoryManager.GetAllAsync(), "Id", "CategoryName");
            return View(model);
        }

        public async Task<IActionResult> MovieList(int? categoryId)
        {
            ViewBag.Categories = await _categoryManager.GetAllAsync();

            var movies = await _movieManager.GetAllMoviesWithCategoriesAsync();
            if (categoryId.HasValue)
            {
                movies = movies.Where(m => m.MovieCategories.Any(mc => mc.CategoryId == categoryId.Value)).ToList();
            }

            return View(movies);
        }
    }
}