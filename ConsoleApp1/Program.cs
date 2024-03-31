using System;
using ConsoleApp1.Models;

class Program
{
    static void Main(string[] args)
    {
        FilmLibrary library = new FilmLibrary();

        // Додайте приклади фільмів до бібліотеки
        Movie movie1 = new Movie { Title = "Inception", Studio = "Warner Bros.", Genre = "Science Fiction", Year = 2010, Director = "Christopher Nolan", Cast = new string[] { "Leonardo DiCaprio", "Joseph Gordon-Levitt" }, Summary = "A thief who enters the dreams of others to steal their secrets", Rating = 9, Location = "C:\\Movies\\Inception.mp4", Size = 1500 };
        library.AddMovie(movie1);

        // Перевірка наявності фільму в бібліотеці
        string movieToCheck = "Inception";
        if (library.CheckMovieExists(movieToCheck))
        {
            Console.WriteLine($"The movie '{movieToCheck}' exists in the library.");
        }
        else
        {
            Console.WriteLine($"The movie '{movieToCheck}' does not exist in the library.");
        }

        // Додайте інші функції бібліотеки та взаємодію з користувачем тут
    }
}
