using System.Reflection;
using System;
using System.Collections.Generic;

namespace thisLibrary
{
    public class Book
    {
        public string Author;
        public string Title;
        public int Pages;

        public Book(string title, string author, int pages)
        {
            Author = author;
            Title = title;
            Pages = pages;
        }

    }
    
}
