using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using eTickets.Models;
using eTickets.Entities.Model.Concrete;
using eTickets.BL.Managers.Abstract;
using Microsoft.EntityFrameworkCore;
using eTickets.ViewModels;
using Google.Protobuf.WellKnownTypes;

namespace eTickets.Controllers
{
    //[Area("Home")]
    public class HomeController : Controller
    {
        private readonly IMovieManager _movieManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IActorManager _actorManager;
        private readonly IMovieActorManager _movieActorManager;
        private readonly IMovieCategoryManager _movieCategoryManager;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public HomeController(IWebHostEnvironment webHostEnvironment, IMovieManager movieManager, ICategoryManager categoryManager, IMovieActorManager movieActorManager, IMovieCategoryManager movieCategoryManager, IActorManager actorManager)
        {
            _movieManager = movieManager;
            _categoryManager = categoryManager;
            _movieActorManager = movieActorManager;
            _movieCategoryManager = movieCategoryManager;
            _actorManager = actorManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> movies = _movieManager.GetAll().Take(3).ToList();
            return View(movies);
        }
        public async Task<IActionResult> Movies(int? actorId)
        {
            var movies = await _movieManager.GetAllMoviesWithActorsAsync();

            if (actorId.HasValue)
            {
                // Aktör ID'ye göre filtreleme yap
                movies = movies.Where(m => m.MovieActors.Any(ma => ma.ActorId == actorId.Value)).ToList();
                var actor = await _actorManager.GetByIdAsync(actorId.Value);
                ViewBag.ActorName = actor.ActorName;
            }
            
            return View(movies);
        }
        public async Task<IActionResult> Actors()
        {
            List<Actor> actors = await _actorManager.GetAllAsync();
            if(actors == null) { return NotFound(); }
            return View(actors);
        }
        public IActionResult CinemaSaloons()
        {
            return View();
        }
        public async Task<IActionResult> Seating(int id)
        {
            Movie movie = await _movieManager.GetByIdAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpGet]
        public async Task<IActionResult> BuyTicket(int id, string seats, int price, string selectedSaloon)
        {
            var movie = await _movieManager.GetMovieByIdAsync(id); 

            if (movie == null)
            {
                return NotFound(); // Eðer film bulunamazsa 404 döndür
            }

            List<string> seatList = seats.Split(',').ToList();
            CreateTicketViewModel model = new CreateTicketViewModel
            {
                MovieName = movie.MovieName,
                ReleaseDate = movie.ReleaseDate,    
                PhotoUrl = movie.PhotoUrl,
                Duration = movie.Duration,
                Seats = seatList,
                Price = price,
                Saloon = selectedSaloon
            };

            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await _movieManager.GetAllMoviesWithCategoriesAndActorsByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            // Initialize ViewBag.MovieActors as a list
            ViewBag.MovieActors = new List<Actor>();
            ViewBag.MovieCategories =new List<Category>();
            foreach (var actor in movie.MovieActors)
            {
                var actorDetails = await _actorManager.GetByIdAsync(actor.ActorId);
                if (actorDetails != null)
                {
                    ((List<Actor>)ViewBag.MovieActors).Add(actorDetails);
                }
            }
            foreach (var category in movie.MovieCategories)
            {
                var categories = await _categoryManager.GetByIdAsync(category.CategoryId);
                if (categories != null)
                {
                    ((List<Category>)ViewBag.MovieCategories).Add(categories);
                }
            }
            return View(movie);
        }
        public IActionResult SeatingPlan()
        {
            return View();
        }
        public IActionResult Profiles()
        {
            return View();
        }
    };
}





