class Program
{
    static void Main()
    {
        //display title
        Console.WriteLine("***Banking Application***");
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
                Console.WriteLine("\n--Main menu--");
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
                    case 1:CustomerMenu(); //TO DO: Display Customer Menu
                        break;
                    case 2: AccountsMenu();//TO DO: Display Account Menu
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

    static void CustomerMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //fo-while loop starts
        do
        {
            //print customers menu
            Console.WriteLine("\n--Customer Menu--");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Delete Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.View Customer");
            Console.WriteLine("0.Back to Main Menu");

            //accept customer menu choice
            Console.WriteLine("Enter choice");
            customerMenuChoice = System.Convert.ToInt32(Console.ReadLine());

        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //variable to store customers menu choice
        int accountsMenuChoice = -1;

        //fo-while loop starts
        do
        {
            //print customers menu
            Console.WriteLine("\n--Accounts Menu--");
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2.Delete Account");
            Console.WriteLine("3.Update Account");
            Console.WriteLine("4.View Account");
            Console.WriteLine("0.Back to Main Menu");

            //accept customer menu choice
            Console.WriteLine("Enter choice");
            accountsMenuChoice = System.Convert.ToInt32(Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }
}