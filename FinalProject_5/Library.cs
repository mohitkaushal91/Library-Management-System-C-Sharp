using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_5
{
    static class Library
    {
        // Creating a static List of Media
        public static List<Media> media = new List<Media>()
        {
            new Movie("The Matrix"),
            new Movie("3 Idiots"),
            new Movie("Braveheart"),
            new Movie("The Lion King"),
            new Movie("Hera Pheri"),
            new Magazine("Canadian Living"),
            new Magazine("Toronto Life"),
            new Magazine("Style at Home"),
            new Magazine("Sportsnet Magazine"),
            new Magazine("Shift"),
            new Book("Alias Grace", "book"),
            new Book("The Stone Angel", "book"),
            new Book("Life of Pi", "book"),
            new Book("Indian Horse", "book"),
            new Book("Three Day Road", "book")
        };

        // Creating a static List of Library Members 
        public static List<LibraryMember> librarymembers = new List<LibraryMember>()
        {
            new LibraryMember("Mohit"),
            new LibraryMember("Maninder"),
            new LibraryMember("Jared"),
            new LibraryMember("Braden"),
            new LibraryMember("Karan")
        };
    }
}
