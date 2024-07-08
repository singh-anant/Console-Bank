using System;
namespace Console_Bank
{
	public class ConsoleBank
	{
		public void launchBank()
		{
			String userName = null;
			String password = null;


            Console.WriteLine("$WELCOME TO CONSOLE BANK$");
            Console.WriteLine("Please enter your username and password:");
			Console.Write("Username:");
			 userName = Console.ReadLine();


//reading the password if the username is not empty....
			if (userName != "")
			{
                Console.Write("\nPassword:");
                 password = Console.ReadLine();
            }
//checking hte username and password

			if(userName=="System" && password=="manager")
			{
				System.Console.WriteLine("To display main menu");
			}

			System.Console.WriteLine("Thanks for the visit");
            System.Console.ReadKey();



        }
    }
}

