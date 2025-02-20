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
            //declare variable to store menu choice
            int mainMenuChoice = -1;

            do
            {
                //show main menu
                Console.WriteLine("Main menu");
                Console.WriteLine("1.Customer");
                Console.WriteLine("2.Account");
                Console.WriteLine("3.Funds Transfer");
                Console.WriteLine("4.Funds Transfer Statement");
                Console.WriteLine("5.Account Statement");
                Console.WriteLine("0.Exit");

                //accept menu choice from keyboard
                Console.WriteLine("Enter choice:");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: //TO DO: Display Customer Menu
                        break;
                    case 2: //TO DO: Display Account Menu
                        break;
                    case 3: //TO DO: Display Funds Transfer Menu
                        break;
                    case 4: //TO DO: Display Funds Transfer Statement Menu
                        break;
                    case 5: //TO DO: Display Account Statement Menu
                        break;
                } 
            } while (mainMenuChoice != 0);
        }

        //about to exit
        Console.WriteLine("Thank you! Visit again");
        Console.ReadLine();
    }
}