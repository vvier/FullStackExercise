using System.Collections.Generic;
using Gig.Models;

namespace Gig.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Time { get; set; }

        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}