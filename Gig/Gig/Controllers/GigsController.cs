using System;
using System.Linq;
using System.Web.Mvc;
using Gig.Models;
using Gig.ViewModels;
using Microsoft.AspNet.Identity;

namespace Gig.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var userId = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == userId);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            var gig = new Models.Gig
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venue = viewModel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}