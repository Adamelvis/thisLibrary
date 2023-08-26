using System;
using System.Collections.Generic;

namespace thisLibrary
{
    public class Program
    {
        
        // funktion för att lägga till böcker
        static void AddBooks(Library libraryName, List<string> books2Add)
        {
            
            var numBooks = books2Add.Count / 3;
            Console.WriteLine("Books added to library. Amount:" + numBooks.ToString());
            Console.WriteLine("Books being:");
            
            // börja med att sortera listan med titlar, författare och sidor
            for (int i = 0; i < books2Add.Count; i+=3)
            {
                libraryName.Books.Add(new Book(books2Add[i], books2Add[i+1], int.Parse(books2Add[i+2])));
                Console.WriteLine(" - " + books2Add[i] + " by " + books2Add[i+1] + " with " + books2Add[i+2] + " pages.");
            }
            

        }
        
        static void Main(string[] args)
        {

        // skapa ett nytt bibleotek
        var lib1 = new Library();
        
        
        // skapa en lista med böcker    
        List<string> newBooks = new List<string>
        {
            "Harry Potter",
            "J.K. Rowling",
            "123",

            "Minecraft Bible",
            "Steve Christ",
            "700",
            
            "The Bible",
            "God",
            "777"
        };

            
        // lägg till böckerna i biblioteket
        AddBooks(lib1, newBooks);

        
        }
    }
}