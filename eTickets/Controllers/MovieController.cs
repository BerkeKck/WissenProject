using eTickets.BL.Managers.Abstract;
using eTickets.BL.Managers.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieManager _movieManager;
        private readonly ICategoryManager _categoryManager;

        private readonly IMovieActorManager _movieActorManager;
        private readonly IMovieCategoryManager _movieCategoryManager;

        public MovieController(MovieManager movieManager, ICategoryManager categoryManager, IMovieActorManager movieActorManager, IMovieCategoryManager movieCategoryManager)
        {
            _movieManager = movieManager;
            _categoryManager = categoryManager;
            _movieActorManager = movieActorManager;
            _movieCategoryManager = movieCategoryManager;
        }

        public IActionResult Index()
        {
            return View();
        }





    }
}
