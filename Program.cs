using System;

namespace A4_Movie_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            // I don't know why this isn't working. I struggled with this program.
            // So I just tried my best to get down what would work

            // create boolean to exit program
            bool exit = false;
            // while boolean exit is false do this code
            while (exit == false)
            {
                // Display menu to add and display movies or exit
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Display movies");
                Console.WriteLine("3. To exit");
                // Let user input value and turn it into an int
                int userInput = Convert.ToInt32(Console.ReadLine());

                // If user input is 1, add movie options
                if (userInput == '1')
                {
                    Movie movie = new Movie();
                    movie.addMovie();
                    movie.addMovieFile();
                }
                // else if user option is 2, display options
                else if (userInput == '2')
                {   
                    DisplayMovies movieList = new DisplayMovies();
                    movieList.displayList();
                }
                // else if user input is 3, exit program
                else if (userInput == '3')
                {
                    exit = true;
                }
                // else output "invaild input"
                else 
                {
                    Console.WriteLine("Invalid input.");
                }
            }

        }
    }
}
