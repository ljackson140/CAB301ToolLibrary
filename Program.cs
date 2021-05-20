using System;

namespace cab301Assignment
{
    class Program
    {
        static bool isInStaffMenu = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void runProgram()
        {
             string username;

            while (true)
            {
                int main_menu_selection = MainMenu();

                if(main_menu_selection == 1)
                {
                    bool login_success = StaffLogin();
                    while (login_success)
                    {
                        isInStaffMenu = true;
                        while (isInStaffMenu)
                        {
                            int staff_menu_selection = StaffMenu();


                        }
                    }
                }
            }
        }

        static int MainMenu()
        {
            int user_input;

            Console.WriteLine("\nWelcome to the Community Library"
                            + "\n===========Main Menu==========="
                            + "\n 1. Staff Login"
                            + "\n 2. Member Login"
                            + "\n 0. Exit"
                            + "\n==============================="
                            + "\n\nPlease make a selection  (1-2 or 0 to exit):");

            // Get user input
            string input = Console.ReadLine();
            user_input = Int32.Parse(input);

            return user_input;
        }

        static int MemberMenu()
        {
            int user_input;

            Console.WriteLine("\n===========Member Menu==========="
                            + "\n 1. Display all movies"
                            + "\n 2. Borrow a movie DVD"
                            + "\n 3. Return a movie DVD"
                            + "\n 4. List current borrowed movie DVDs"
                            + "\n 5. Display top 10 most popular movies"
                            + "\n 0. Return to main menu"
                            + "\n=============================="
                            + "\n\nPlease make a selection (1-5 or 0 to return to main menu)");

            // Get input
            string input = Console.ReadLine();
            user_input = Int32.Parse(input);

            return user_input;
        }

        static bool StaffLogin()
        {
            bool login_success = false;

            if (staffUsernameCheck())
            {
                if (staffPasswordCheck())
                {
                    login_success = true;
                }
            }
            return login_success;
        }

        static bool staffUsernameCheck()
        {
            bool staff_check = false;

            Console.WriteLine("Enter username: ");

            // While staff check is false
            while (!staff_check)
            {

                // Get username
                string input = Console.ReadLine();

                // Check if input is 'Staff'
                if (input == "staff")
                {
                    staff_check = true;
                }
                else
                {
                    Console.WriteLine("Invalid username");
                    continue;
                }
            }
            return staff_check;
        }

        /// <summary>
        /// Checks the staff password
        /// </summary>
        /// <returns>If the staff password was correct</returns>
        static bool staffPasswordCheck()
        {
            bool staff_check = false;

            Console.WriteLine("Enter password: ");

            // While staff check is false
            while (!staff_check)
            {
                // Get password
                string input = Console.ReadLine();

                // Check if input is 'today123'
                if (input == "today123")
                {
                    staff_check = true;
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                    continue;
                }
            }
            return staff_check;
        }

        static int StaffMenu()
        {
            int user_input;

            Console.WriteLine("\n===========Staff Menu==========="
                            + "\n 1. Add a new movie DVD"
                            + "\n 2. Remove a movie DVD"
                            + "\n 3. Register a new Member"
                            + "\n 4. Find a registered member's phone number"
                            + "\n 0. Return to main menu"
                            + "\n=============================="
                            + "\n\nPlease make a selection (1-4 or 0 to return to main menu)");

            // Get user input
            string input = Console.ReadLine();
            user_input = Int32.Parse(input);

            return user_input;
        }


    }
}
