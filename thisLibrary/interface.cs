namespace thisLibrary;

public class iFace {
    
    public static void Start()
    {
        
        Console.WriteLine("Welcome to the library!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Add books");
        Console.WriteLine("2. Remove books");
        Console.WriteLine("3. Add Library");
        Console.WriteLine("4. Remove Library");
        Console.WriteLine("5. Look inside libraries");
        
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                f.AddBooks();
                iFace.Start();
                break;
            case "2":
                f.RemoveBooks();
                iFace.Start();
                break;
            case "3":
                f.AddLibrary();
                iFace.Start();
                break;
            case "4":
                break;
            
            case "5":
                f.LookInsideLibrary();
                iFace.Start();
                break;
            default:
                Console.WriteLine("Error. Please try again.");
                Console.ReadLine();
                iFace.Start();
                break;
        } 
        
    }
}