using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FilmLib.Models
{
    public static class Data
    {
        private const string FilePath = "movies.json";

        public static void SaveMovies(List<Movie> movies)
        {
            string json = JsonSerializer.Serialize(movies);
            File.WriteAllText(FilePath, json);
        }

        public static List<Movie> LoadMovies()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>() ;
            }
            else
            {
                return new List<Movie>();
            }
        }
    }
}
