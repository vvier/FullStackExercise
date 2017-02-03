using System.Collections.Generic;
using Learning.Models;

namespace Learning.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Time { get; set; }

        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}