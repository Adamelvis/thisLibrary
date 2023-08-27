namespace thisLibrary;

public class f
{

    public static void AddLibrary()
    {
        Console.WriteLine("What would you like to name the library?");
        var libraryName = Console.ReadLine();

        Libraries.Add(new Library(libraryName));
        
        Console.WriteLine("Library Added!");
    }
    
    
    public static void AddBooks()
    {
        
        Console.WriteLine("What library would you like to add to?");
        
        /*
        var numBooks = books2Add.Count / 3;
        Console.WriteLine("Books added to library. Amount:" + numBooks.ToString());
        Console.WriteLine("Books being:");
            
        // börja med att sortera listan med titlar, författare och sidor
        for (int i = 0; i < books2Add.Count; i+=3)
        {
            libraryName.Books.Add(new Book(books2Add[i], books2Add[i+1], int.Parse(books2Add[i+2])));
            Console.WriteLine(" - " + books2Add[i] + " by " + books2Add[i+1] + " with " + books2Add[i+2] + " pages.");
        }
        */
    }
    public static void RemoveBooks()
    {
        
    }
}