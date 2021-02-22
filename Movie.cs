using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace A4_Movie_Library
{
    public class Movie
    {
        // Create movieID and title and a genre list
        public int movieID {get; set;}
        public string title {get; set;}
        public List<string> Genre = new List<string>();
        string movieFile = "Movies.csv";

        // Made a way to get ID without user input because you can't do it that way
        private int getID()
        {
            int ID = 0;
            
            try
            {
                string lastLine = System.IO.File.ReadLines(movieFile).Last();
                string[] lastLineSplit = lastLine.Split(',');
                ID = Convert.ToInt32(lastLineSplit[0]);
                return ID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            return ID;
        }

        // Add movie method (when user enters '1')
        public void addMovie()
        {
            Console.WriteLine("Enter movie title: ");
            title = Console.ReadLine();
            if (string.Equals(title, title) == true)
            {
                Console.WriteLine("Title can't be the same.");
                Console.WriteLine("Enter movie title: ");
                title = Console.ReadLine();
            }

            int count = 1;
            while (true)
            {
                Console.WriteLine("Enter genre " + count + " (Enter 0 to stop)");
                string genre = Console.ReadLine();

                if (genre == "0")
                {
                    break;
                } 
                
                Genre.Add(genre);
                count++;
            }
            movieID = getID() + 1;
        }

        // Add movie to file method (alse when user enters '1')
        public void addMovieFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter(movieFile, true);
                sw.WriteLine(ToString());
                Console.WriteLine("Movie was successfully added");
                sw.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }

        private string genreList(List<string> genres)
        {
            return string.Join("|", genres);
        }

        public override string ToString()
        {
            string genres = genreList(Genre);
            return movieID + ", " + title + ", " + genres;
        }
    }
}