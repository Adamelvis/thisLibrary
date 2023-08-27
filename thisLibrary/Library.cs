using System;
using System.Collections.Generic;


namespace thisLibrary
{
    public class Library
    {
        public string LibraryName;
        
        // skapa en tom lista med böcker
        public List<Book> Books;

        public Library(string libraryName)
        {
            LibraryName = libraryName;
            
            Books = new List<Book>();
        }
    }
}
