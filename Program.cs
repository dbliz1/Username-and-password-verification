namespace Opgave_026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A program that verifies username and password.

            // Declaration of variables
            string username, password;
            string username1, password1;

            // Intro message to the user
            Console.WriteLine(" Hello, please create an account.");

            Console.WriteLine();

            // Here we ask user to enter his/her desired username and password.
            Console.Write(" Please enter a desired username: ");
            username = Console.ReadLine();

            Console.WriteLine();

            Console.Write(" Enter a password of your choice: ");
            password = Console.ReadLine();

            Console.WriteLine();

            // Here we clear everything on the screen and ask the user to enter his/her details again so the program can verify.
            Console.Clear();

            Console.Write(" Enter your username again: ");
            username1 = Console.ReadLine();

            Console.WriteLine();

            Console.Write(" Repeat your entered password here: ");
            password1 = Console.ReadLine();

            Console.WriteLine();

            // Now introduce our IF statement condition to verify the details
            if(username1 != username || password1 != password) 
            {
                Console.WriteLine(" Wrong username or password.");

                Console.WriteLine();

                Console.WriteLine(" ACCESS DENIED. ");
            }
            else
            {
                Console.WriteLine(" WELCOME TO THE SYSTEM");
            }

            // Program ends with a key press
            Console.ReadKey();
        }
    }
}
