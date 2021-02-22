using System;
using System.IO;
using System.Collections.Generic;

namespace A4_Movie_Library
{
    public class DisplayMovies
    {
        // Create const ints for column sizes
        private const int ID_COLUMN = -10;
        private const int GENRE_COLUMN = -30;
        private const int TITLE_COLUMN = -50;
        // Create movie list
        private List<string> movieList = new List<string>();

        // I originally had the copied directory but then it couldn't read that so I just did movies.csv?
        private string movieFile = "Movies.csv";

        public DisplayMovies()
        {
            moveToCsv();
        }

        private void moveToCsv()
        {
            while (true)
            {
                // Prompt user with how many movies they would like to add
                Console.WriteLine("How many movies would you like to display?");
                string input = Console.ReadLine();
                int inputNumber;

                if (int.TryParse(input, out inputNumber))
                {
                    StreamReader sr = new StreamReader(movieFile);
                    for (int i = 0; i < inputNumber; i++)
                    {
                        string movieLine = sr.ReadLine();
                        movieList.Add(movieLine);
                    }
                    sr.Close();
                    break;
                }
                Console.WriteLine("Enter a number");
            }
        }

        public void displayList()
        {
            foreach (var movie in movieList)
            {
                // Output the movie info
                string[] movieInfo = movie.Split(',');
                Console.WriteLine($"|{movieInfo[0], ID_COLUMN} | {movieInfo[1], TITLE_COLUMN} | {movieInfo[2], GENRE_COLUMN}");
            }
        }

    }

}