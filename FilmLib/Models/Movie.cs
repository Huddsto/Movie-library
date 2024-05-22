using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLib.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int YearOfRelease { get; set; }
        public string Director { get; set; }
        public string LeadActors { get; set; }
        public string Summary { get; set; }
        public double Score { get; set; }
        public string Location { get; set; }
        public long FileSize { get; set; }
        public int Length { get; set; }
    }
}
