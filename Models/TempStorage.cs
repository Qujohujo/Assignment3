using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TempStorage
    {
        private static List<ApplicationResponse> movies = new List<ApplicationResponse>();

        public static IEnumerable<ApplicationResponse> MovieAdditions => movies;

        public static void AddMovie(ApplicationResponse movie)
        {
            movies.Add(movie);
        }
    }
}
