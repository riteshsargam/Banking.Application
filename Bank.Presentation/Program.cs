class Program
{
    static void Main()
    {
        //display title
        Console.WriteLine("******Banking Application***");
        Console.WriteLine("--Login Page--");

        //declare variables to store username and password;
        string userName = null, password = null;

        //read userName from keyboard
        Console.Write("Username:");
        userName = Console.ReadLine();

        //read password from keyboard
        Console.Write("Password:");
        password = Console.ReadLine();

        //check username and password
        if (userName == "system" && password == "manager")
        {
            Console.WriteLine("TO DO: Main menu here");
        }

        //about to exit
        Console.WriteLine("Thank you! Visit again");
        Console.ReadLine();
    }
}