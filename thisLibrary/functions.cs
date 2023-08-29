namespace thisLibrary;

public class f
{

    public static void AddLibrary()
    {
        Console.WriteLine("What would you like to name the library?");
        var libraryName = Console.ReadLine();

        Program.Libraries.Add(new Library(libraryName));
        
        Console.WriteLine("Library, "+ libraryName+", successfully added!");
        Console.ReadLine();

    }

    public static void RemoveLibrary()
    {
        if (Program.Libraries.Count > 0)
        {
            Console.WriteLine("What library would you like to remove?");


            // lista alla bibleotek
            for (int i = 0; i < Program.Libraries.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + Program.Libraries[i].LibraryName);
            }

            var input = int.Parse(Console.ReadLine()) - 1;
            Library selectedLibraryName = Program.Libraries[input];

            Console.WriteLine("Are you sure you want to remove " + selectedLibraryName.LibraryName + "?");
            Console.WriteLine("1. yes");
            Console.WriteLine("2. no");

            var answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Program.Libraries.Remove(selectedLibraryName);
                    Console.WriteLine("Library removed!");
                    Console.ReadLine();
                    iFace.Start();
                    break;
                case 2:
                    iFace.Start();
                    break;
                default:
                    Console.WriteLine("Error. Please try again!");
                    iFace.Start();
                    break;
            }
        }
        else
            {
                Console.WriteLine("No library to delete!");
                Console.ReadLine();
                iFace.Start();
            }
    }

    public static void LookInsideLibrary()
    {
        if (Program.Libraries.Count > 0)
        {
            Console.WriteLine("What library would you like to look inside of?");

                
            // lista alla bibleotek
            for (int i = 0;i < Program.Libraries.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + Program.Libraries[i].LibraryName);
            }

            var input = int.Parse(Console.ReadLine()) - 1;
            Library selectedLibraryName = Program.Libraries[input];
            
            if (selectedLibraryName.Books.Count() > 0)
            {
                Console.WriteLine(selectedLibraryName.LibraryName + ": ");
                
                // lista alla böcker innuti bibleoteket
                for (int i = 0;i < selectedLibraryName.Books.Count(); i++)
                {
                    var title = selectedLibraryName.Books[i].Title;
                    var author = selectedLibraryName.Books[i].Author;
                    Console.WriteLine(" - " + title + " by " + author);
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No books here!");
                Console.ReadLine();
                iFace.Start();
            }
        }
        else
        {
            Console.WriteLine("No libraries to look inside of.");
            Console.ReadLine();
        }

    }
    
    public static void AddBooks()
    {
        

        if (Program.Libraries.Count > 0)
        {
            Console.WriteLine("What library would you like to add to?");
            for (int i = 0;i < Program.Libraries.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + Program.Libraries[i].LibraryName);
            }

            var input = int.Parse(Console.ReadLine()) - 1;
            Library selectedLibraryName = Program.Libraries[input];
            
            Console.WriteLine("What is the Title of the book you wish to add?");
            var title = Console.ReadLine();
            Console.WriteLine("What is the Author of the book?");
            var author = Console.ReadLine();
            Console.WriteLine("How many pages are in the book?");
            var pages = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Great! Adding the book " + title + " by " + author + " with " + pages + "pages.");
            selectedLibraryName.Books.Add(new Book(title, author, pages));
            
            Console.WriteLine("Would you like to add another book?");
            Console.WriteLine("1. yes");
            Console.WriteLine("2. no");

            switch (Console.ReadLine())
            {
                case "1":
                    f.AddBooks();
                    break;
                case "2":
                    iFace.Start();
                    break;
                default:
                    Console.WriteLine("Error. Please try again!");
                    f.AddBooks();
                    break;
            }
            

        }
        else
        {
            Console.WriteLine("No libraries to add books too.");
            Console.ReadLine();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

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
        if (Program.Libraries.Count > 0)
        {
            Console.WriteLine("What library would you like to remove a book in?");

                
            // lista alla bibleotek
            for (int i = 0;i < Program.Libraries.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + Program.Libraries[i].LibraryName);
            }

            var input = int.Parse(Console.ReadLine()) - 1;
            Library selectedLibraryName = Program.Libraries[input];
            
            if (selectedLibraryName.Books.Count() > 0)
            {
                Console.WriteLine("What book would you like to remove?");
                
                // lista alla böcker innuti bibleoteket
                for (int i = 0;i < selectedLibraryName.Books.Count(); i++)
                {
                    var title = selectedLibraryName.Books[i].Title;
                    var author = selectedLibraryName.Books[i].Author;
                    Console.WriteLine((i + 1).ToString() + ": " + title + " by " + author);
                }

                var answer = int.Parse(Console.ReadLine());

                for(int i = 0; i < selectedLibraryName.Books.Count(); i++)
                {
                    if (answer == i + 1)
                    {
                        selectedLibraryName.Books.Remove(selectedLibraryName.Books[i]);
                        Console.WriteLine("Book removed!");
                        Console.ReadLine();
                        iFace.Start();
                    }
                }
                
            }
            else
            {
                Console.WriteLine("No books here to remove!");
                Console.ReadLine();
                iFace.Start();
            }
        }
        else
        {
            Console.WriteLine("No libraries exist.");
            Console.ReadLine();
        }

    }
}