using System;

namespace CAB301TOOL_LIBRARY
{
    class Displays : Database
    {
        //============================================== private fields ====================================================================
        //member fields 
        private static Member loggedNverifiedMember;
        private static MemberCollection members = new MemberCollection();
        private static string nameOfMember = "";
        private static string PIN = "";        
        private static int vMemNumber = 0;

        //staff fields
        private static string sName = "";
        private static string sPIN = "";
        
        //tool fields 
        private static string currChosenTool = "";
        private static bool matchedToolName = false; 
        private static ToolCollection[] entireTC = fetchData();



        public static int[] fetchToolID(string nameOfT)
        {
            int entLen = entireTC.Length;
            for (int n = 0; n < entLen; n++)
            {
                for (int m = 0; m < entireTC[n].toArray().Length; m++)
                {
                    if (entireTC[n].toArray()[m].Name == nameOfT)
                    {
                        return new int[] {n, m};
                    }
                }
            }
            return null;
        }

       
        public static string fetchCurrToolType()
        {
            return currChosenTool;
        }

        public static MemberCollection allMemCollection()
        {
            return members;
        }


        public static ToolCollection[] fetchallTCs()
        {
            return entireTC;
        }

        
        private static ToolCollection fetchViewedTools(string aToolType)
        {
            ToolCollection toolsViewed = new ToolCollection("Displayed Tools");
            int all = entireTC.Length;
            for (int n = 0; n < all; n++)
            {
                if (entireTC[n].Name == aToolType)
                {
                    for (int m = 0; m < entireTC[n].Number; m++)
                    {
                        Tool tool = entireTC[n].toArray()[m];
                        toolsViewed.add(tool);
                    }

                    break;
                }
            }
            return toolsViewed;
        }


        private static void StaffMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("===============Staff Menu===============" +
                "\n 1. Add a new tool" +
                "\n 2. Add new pieces of an existing tool" +
                "\n 3. Remove some pieces of a tool" +
                "\n 4. Register a new member" +
                "\n 5. Remove a member" +
                "\n 6. Find the contact number of a member" +
                "\n 0. Return to main menu" +
            "\n ========================================");
            Console.Write("\n\nSelect between (1 to 6) or 0 to return to Main menu: ");

        }

        private static void MemberMenuScreen()
        {
            Console.WriteLine("===============Member Menu===============" +
                "\n 1. Display all the tools of a tool type" +
                "\n 2. Borrow a tool" +
                "\n 3. Return a tool" +
                "\n 4. List all the tools that I am renting" +
                "\n 5. Display top (3) most frequently rented tools" +
                "\n 0. Return to main menu" +
                "\n ========================================");
            Console.Write("\n\nSelect between (1 to 5) or 0 to return to Main menu: ");
        }

        public static string MainMenuScreen()
        {
            Console.WriteLine("===============Main Menu===============" +
                "\n 1. Staff Login" +
                "\n 2. Member Login" +
                "\n 0. Exit" +
                "\n =======================================");
            Console.Write("\n\nSelect between (1 to 2) or 0 to exit: ");
            return Console.ReadLine();
        }

        public static bool verifiedMember()
        {
            Console.Clear();
            if (nameOfMember == "")            
                Console.Write("Press lastname and firstname(LastnameFirstname): ");
                nameOfMember = Console.ReadLine();
                Console.Write("Press your 4 digit pin: ");
                PIN = Console.ReadLine();
            
            Member[] arrMembers = members.toArray();

            for (int j = 0; j < arrMembers.Length; j++)            
                if (arrMembers[j] != null && (arrMembers[j].LastName + arrMembers[j].FirstName) == nameOfMember && arrMembers[j].PIN == PIN)
                {
                    nameOfMember = arrMembers[j].LastName + arrMembers[j].FirstName;
                    PIN = arrMembers[j].PIN;
                    loggedNverifiedMember = arrMembers[j];
                    return true;
                }
            return false;
        }

        private static string ShowCategories(string title)
        {
            Console.Clear();
            Console.WriteLine("=============Tool Categories============" +
                "\n 1. Gardening tools" +
                "\n 2. Flooring tools" +
                "\n 3. Fencing tools" +
                "\n 4. Measuring tools" +
                "\n 5. Cleaning tools" +
                "\n 6. Painting tools" +
                "\n 7. Electronic tools" +
                "\n 8. Electricity tools" +
                "\n 9. Automotive tools" +
                "\n 0. Return to " + title + " menu" +
                "\n ========================================");
            Console.Write("\n\nSelect between (1 to 9) or 0 to return to " + title + " menu: ");
            string selection = Console.ReadLine();
            return selection;

        }

        private static void ShowMembers()
        {
            Console.WriteLine("==========================Members=========================");
            Console.WriteLine(".. {0, -20}{1, -20}{2, 20}", "First Name", "Last Name", "Contact Number");

            if (members != null) {
                Member[] arrMembers = members.toArray();

                int mems = arrMembers.Length;
                for (int j = 0; j < mems; j++)                
                    if (arrMembers[j] != null){
                        vMemNumber++;
                        Console.WriteLine(j + 1 + ". " + arrMembers[j].ToString());
                    }
            }
        }

        //implement all of the screens from user input
        //incomplete 
        public static void RunMainMenu(string menuselection, ToolLibrarySystem tSys)
        {
            while (menuselection != "0")
            {
                if (menuselection == "1")
                {

                    while (sName.ToLower() != "staff")
                    {
                        Console.Clear();
                        Console.Write("Press Staff username: ");
                        sName = Console.ReadLine();
                        if (sName.ToLower() != "staff")
                        {
                            Console.Write("\nError invalid staff. Press 0 to return to main menu else ");
                            Console.Write("Press anykey to try again: ");
                            string selection = Console.ReadLine();

                            while (selection == "0")
                            {
                                Console.Clear();
                                BackToMainMenu(tSys);
                            }
                        }
                    }

                    if (sName.ToLower() == "staff")
                    {
                        sName = "";
                        while (sPIN != "today123")
                        {
                            Console.Clear();       Console.Write("Press the Staff PIN: ");
                            sPIN = Console.ReadLine();      sName = "staff";
                            if (sPIN != "today123")
                            {
                                Console.Write("\nError incorrect Staff PIN! Press 0 to return to main menu else");
                                Console.Write("Press anykey to try again: ");
                                string selection = Console.ReadLine();
                                while (selection == "0") { Console.Clear(); BackToMainMenu(tSys); }
                            }
                        }
                        StaffMenuScreen();
                        string sSelection = Console.ReadLine();

                        if (sSelection != "0") { RunStaffOptions(sSelection, tSys); }
                        else  { Console.Clear();  sName = ""; sPIN = "";  Console.Clear(); BackToMainMenu(tSys); }
                    }
                }
                else if (menuselection == "2")
                {
                    while (!verifiedMember())
                    {
                        Console.Clear();
                        Console.Write("Invalid Credentials...Use format of LastnameFirstname to sign in:");
                        Console.Write("\nPress 0 to return to MainMenu or ");
                        Console.Write("Press anykey to try again: ");

                        nameOfMember = "";
                        string selection = Console.ReadLine();
                        while (selection == "0") { Console.Clear(); BackToMainMenu(tSys); }                      
                                                  
                    }

                    Console.Clear();  MemberMenuScreen();
                    string memSelection = Console.ReadLine();

                    if (memSelection != "0") { RunMemberOptions(memSelection, tSys);
                    }
                    else { nameOfMember = ""; BackToMainMenu(tSys); }

                }
                else {  Console.Write("Incorrect selection! Select between (1 or 2) or 0 to exit: ");  menuselection = Console.ReadLine(); }
            }
            Environment.Exit(0);
        }
        
        private static string ShowToolTypes(string selection, ToolLibrarySystem sys, string title)
        {
            while (selection != "2" && selection != "1" && selection != "0" && selection != "3" && selection != "6" && selection != "5" && selection != "4" && selection != "7" && selection != "8" && selection != "9")            
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Staff menu: ");
                selection = Console.ReadLine();
            

            if (selection == "1")
            {
                string typeOfTool = GardenCategoryTools();
                if (typeOfTool == "back")
                {
                    string catSelection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catSelection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "2")
            {
                string typeOfTool = FlooringCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "3")
            {
                string typeOfTool = FencingCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "4")
            {
                string typeOfTool = MeasuringCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "5")
            {
                string typeOfTool = CleaningCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "6")
            {
                string typeOfTool = PaintingCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "7")
            {
                string typeOfTool = ElectronicCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "8")
            {

                string typeOfTool = ElectricityCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else if (selection == "9")
            {
                string typeOfTool = AutomotiveCategoryTools();
                if (typeOfTool == "back")
                {
                    string catselection = ShowCategories("Staff");
                    typeOfTool = ShowToolTypes(catselection, sys, title);
                }
                return typeOfTool;
            }
            else
            {
                RunMainMenu(title, sys);
            }
            return "Incorrect selection";
        }
              
        private static void BackToStaffMenu()
        {
            Console.WriteLine("\nPress 0 to return to Staff menu:  ");
            sName = "staff";
            sPIN = "today123";
            string selection = Console.ReadLine();
            while (selection != "0")
            {
                Console.Write("Incorrect Selection! Please enter 0 to return to Staff menu: ");
                selection = Console.ReadLine();
            }

        }
        
        private static void BackToMemberMenu()
        {
            Console.Write("\nPress 0 to return to Member menu: ");
            string selection = Console.ReadLine();
            while (selection != "0")
            {
                Console.Write("Incorrect Selection! Please enter 0 to return to Member menu: ");
                selection = Console.ReadLine();
            }
        }

        private static void BackToMainMenu(ToolLibrarySystem tSys)
        {
            Console.Clear();
            string selection = MainMenuScreen();
            RunMainMenu(selection, tSys);
        }

        private static Tool InsertTool(ToolLibrarySystem tSys, string typeOfTool)
        {
            Console.Write("Press ToolName: ");
            string namOfTool = Console.ReadLine();
            Console.Write("Press quantity: ");

            string amountRead = Console.ReadLine(); int amount;
            while (!int.TryParse(amountRead, out amount))
            {
                Console.Write("Invalid input! Press an integer value: ");
                amountRead = Console.ReadLine();
            }


            Tool libraryTL = new Tool(namOfTool);
            ToolCollection toolsInTheToolType = null;
            for (int i = 0; i < entireTC.Length; i++)
            {
                if (typeOfTool == entireTC[i].Name)
                {
                    toolsInTheToolType = entireTC[i];
                }
            }

            for (int i = 0; i < toolsInTheToolType.Number; i++)
            {
                if (namOfTool == toolsInTheToolType.toArray()[i].Name)
                {
                    libraryTL = toolsInTheToolType.toArray()[i];

                    Console.WriteLine("\nTool already in the system, new pieces of this tool will be added.");
                    Console.Write("Press anykey to continue.\n");
                    Console.ReadKey();
                    matchedToolName = true;
                }
            }  tSys.add(libraryTL, amount);
            return libraryTL;
        }

        private static Member MemberCreation()
        {
            Console.Write("\nEnter FirstName:   ");
            string fName = Console.ReadLine();
            while (!Char.IsUpper(fName[0]))
            {
                Console.Write("\nFirst letter must be capitalised, try again: ");
                fName = Console.ReadLine();
            }

            Console.Write("\nEnter LastName:   ");
            string lName = Console.ReadLine();
            while (!Char.IsUpper(lName[0]))
            {
                Console.Write("\nFirst letter must be capitalised, try again: ");
                lName = Console.ReadLine();
            }

            Console.Write("\nEnter Contact Number:     ");
            string num = Console.ReadLine();
            while (!long.TryParse(num, out _))
            {
                Console.Write("Invalid input! Press positive values: ");
                num = Console.ReadLine();
            }

            Console.Write("Press 4 digit password: ");
            string PIN = Console.ReadLine();
            while (!int.TryParse(PIN, out _) || PIN.Length != 4)
            {
                Console.Write("Invalid input. Press 4 digits: ");
                PIN = Console.ReadLine();
            }

            var member = new Member(fName, lName, num, PIN);

            return member;
        }

        private static void RunStaffOptions(string sSelection, ToolLibrarySystem system)
        {
            while (sSelection != "0" && sSelection != "1" && sSelection != "2" && sSelection != "3" && sSelection != "4" && sSelection != "5" && sSelection != "6")            
                Console.Write("Invaled choice! Select between (1 to 6) or 0 to return to Main menu: ");
                sSelection = Console.ReadLine();        
            if (sSelection == "1")
            {
                string catSelection = ShowCategories("Staff");
                string standardTT = ShowToolTypes(catSelection, system, "1");
                Console.Clear();
                system.displayTools(standardTT);

                currChosenTool = standardTT;
                Tool toolInsertion = InsertTool(system, standardTT);

                if (!matchedToolName){
                    system.add(toolInsertion);
                    matchedToolName = false;
                }
                Console.WriteLine("\n" + toolInsertion.Quantity + " pieces of " + toolInsertion.Name + " has been added");
                Console.WriteLine("Press anykey to continue.");
                Console.ReadKey();
                Console.Clear();
                system.displayTools(standardTT);

                Console.WriteLine("\n\n1. Add a new tool");
                Console.WriteLine("0. Back to StaffMenu");
                Console.Write("\n\nEnter 1 => add a new tool or 0 => return to Staff menu: ");
                string choice = Console.ReadLine();

                while (choice != "1" && choice != "0")
                {
                    Console.Write("Invalid choice! Press 1 => add a new tool or 0 => return to Staff menu: ");
                    choice = Console.ReadLine();
                }
                if (choice == "1")
                {
                    RunStaffOptions(sSelection, system);
                }
                else if (choice == "0")
                {
                    RunMainMenu("1", system);
                }
            }
            else if (sSelection == "2")
            {
                string catSelection = ShowCategories("Staff");
                string standardTT = ShowToolTypes(catSelection, system, "1");
                Console.Clear();
                system.displayTools(standardTT);
                ToolCollection showed_tls = fetchViewedTools(standardTT);
                Console.Write("\n\nPlease make a selection from the tools above: ");
                string c_sng = Console.ReadLine();

                int ISelection;

                while (!int.TryParse(c_sng, out ISelection) || ISelection > showed_tls.Number || ISelection <= 0)
                {
                    Console.Write("Wrong input! Please make a selection from the tools above: ");
                    c_sng = Console.ReadLine();
                }

                Tool chosenT = showed_tls.toArray()[ISelection - 1];
                Console.Write("Please enter the quantity of this tool you want to add: ");
                string quantityString = Console.ReadLine();
                int amonT;

                while (!int.TryParse(quantityString, out amonT))
                {
                    Console.Write("Wrong input! Please enter an integer value: ");
                    quantityString = Console.ReadLine();
                }
                system.add(chosenT, amonT);
                Console.WriteLine("\n" + amonT + " pieces of " + chosenT.Name + " has been added");
                Console.WriteLine("Current quantity: " + chosenT.Quantity);
                Console.WriteLine("\nEnter anykey to continue."); Console.ReadKey();
                Console.Clear(); system.displayTools(standardTT);
                Console.WriteLine("\n0. Back to staff menu");   BackToStaffMenu();
            }
            else if (sSelection == "3")
            {
                string catSelection = ShowCategories("Staff");
                string standardTT = ShowToolTypes(catSelection, system, "1");
                Console.Clear();
                system.displayTools(standardTT);
                var showed_tls = fetchViewedTools(standardTT);
                Console.Write("\n\nSelect tools from above list: ");
                string c_sng = Console.ReadLine();

                int ISelection;

                while (!int.TryParse(c_sng, out ISelection) || ISelection > showed_tls.Number || ISelection <= 0)
                {
                    Console.Write("Invalid input! Select from above list: ");
                    c_sng = Console.ReadLine();
                }

                Tool chosenT = showed_tls.toArray()[ISelection - 1];
                Console.Write("Press quantity of this tool you want to remove: ");
                string quantityString = Console.ReadLine();
                int amonT;

                while (!int.TryParse(quantityString, out amonT) || amonT > chosenT.AvailableQuantity)
                {
                    Console.Write("Wrong input! Please enter an integer value less than available quantity: ");
                    quantityString = Console.ReadLine();
                }

                system.delete(chosenT, amonT);
                Console.WriteLine("\n" + amonT + " pieces of " + chosenT.Name + " has been deleted");
                Console.WriteLine("Current quantity: " + chosenT.Quantity);
                Console.WriteLine("\nPress anykey to continue."); Console.ReadKey(); Console.Clear(); system.displayTools(standardTT);
                Console.WriteLine("\n\n0. Return to staff menu"); BackToStaffMenu();
            }
            else if (sSelection == "4")
            {
                Console.Clear();  ShowMembers(); Member member = MemberCreation(); system.add(member);
                Console.WriteLine("\n" + member.FirstName + " " + member.LastName + " has been added. ");
                Console.WriteLine("\nPress any key to continue."); Console.ReadKey(); Console.Clear(); ShowMembers(); BackToStaffMenu();
            }
            else if (sSelection == "5")
            {
                Console.Clear();
                ShowMembers();
                Console.Write("\n\nPlease select the member you want to remove or enter 0 to return to Staff menu: ");

                int ISelection;
                string c_sng = Console.ReadLine();

                while (!int.TryParse(c_sng, out ISelection) || ISelection <= 0 || ISelection > vMemNumber)                {
                    Console.Write("Wrong input! Please make a selection from the member IDs above: ");
                    c_sng = Console.ReadLine();
                }

                if (ISelection == 0)  {  RunMainMenu("1", system); }

                var memberToDelete = members.toArray()[ISelection - 1];
                system.delete(memberToDelete);

                Console.Clear();
                ShowMembers();
                Console.WriteLine("\n\n0. Return to staff menu");
                BackToStaffMenu();

            }
            else if (sSelection == "6")
            {
                Console.Clear();
                Console.Write("Press member FirstName: ");
                string firstName = Console.ReadLine();
                Console.Write("Press member LastName:  ");
                string lastName = Console.ReadLine();
                bool matchedUser = false;

                Member[] arrMembers = members.toArray();
                int tmembers = arrMembers.Length;
                for (int i = 0; i < tmembers; i++){
                    if (arrMembers[i] != null && arrMembers[i].LastName.ToLower() == lastName.ToLower() && arrMembers[i].FirstName.ToLower() == firstName.ToLower())
                    {
                        Console.Clear();
                        Console.WriteLine("Contact Number: " + arrMembers[i].ContactNumber);
                        matchedUser = true;
                        break;
                    }
                }
                if (!matchedUser) { Console.WriteLine("\nMember not matched! Try again."); }
                Console.WriteLine("\n\n0. Back to staff menu");
                BackToStaffMenu();
            }
            else
            {
                sName = ""; sPIN = "";
                BackToMainMenu(system);
            }
        }

        private static void RunMemberOptions(string memSelection, ToolLibrarySystem system)
        {
            while (memSelection != "0" && memSelection != "1" && memSelection != "2" && memSelection != "3" && memSelection != "4" && memSelection != "5")
            {
                Console.Write("Incorrect Selection! Select between (1 to 5) or 0 for Main menu: ");
                memSelection = Console.ReadLine();
            }

            if (memSelection == "1")
            {
                string catSelection = ShowCategories("Member");
                string t_type = ShowToolTypes(catSelection, system, "2");Console.Clear();
                system.displayTools(t_type); BackToMemberMenu();
            }
            else if (memSelection == "2")
            {
                string catSelection = ShowCategories("Member");
                string t_type = ShowToolTypes(catSelection, system, "2"); Console.Clear();
                system.displayTools(t_type);
                var showed_tls = fetchViewedTools(t_type);
                Console.Write("\nSelect from the tools above: ");
                string c_sng = Console.ReadLine();

                int indexChoice;

                while (!int.TryParse(c_sng, out indexChoice) || indexChoice > showed_tls.Number || indexChoice <= 0)
                {
                    Console.Write("Wrong input! Please make a selection from the tools above: ");
                    c_sng = Console.ReadLine();
                }

                var chosenT = showed_tls.toArray()[indexChoice - 1];

                if (system.borrowTool(loggedNverifiedMember, chosenT))
                {
                    Console.Clear();
                    Console.WriteLine("You've successfully borrowed " + chosenT.Name);                    
                    system.displayBorrowingTools(loggedNverifiedMember);
                    BackToMemberMenu();
                }


            }
            else if (memSelection == "3")
            {
                string[] borrowedTools = system.listTools(loggedNverifiedMember);
                Console.Clear();
                system.displayBorrowingTools(loggedNverifiedMember);

                Console.Write("Select a tool from above or enter 0 for Member menu: ");

                string c_sng = Console.ReadLine();
                int indexChoice;

                while (!int.TryParse(c_sng, out indexChoice) || indexChoice <= 0 || indexChoice > borrowedTools.Length)
                {
                    if (indexChoice != 0)
                    {
                        Console.Write("Error. Select from the tools above or select 0 for Member menu: ");
                        c_sng = Console.ReadLine();
                    }
                    else {  RunMainMenu("2", system); }
                }

                string toolToReturnName = system.listTools(loggedNverifiedMember)[indexChoice - 1];
                int[] location = fetchToolID(toolToReturnName);
                var toolToReturn = entireTC[location[0]].toArray()[location[1]];

                system.returnTool(loggedNverifiedMember, toolToReturn);

                Console.WriteLine("\n" + borrowedTools[indexChoice - 1] + " has been returned. ");
                Console.Write("\nEnter anykey to continue.");Console.ReadKey();

                Console.Clear();
                system.displayBorrowingTools(loggedNverifiedMember);
                Console.Write("\nEnter anykey to continue.");Console.ReadKey();
            }
            else if (memSelection == "4")
            {
                Console.Clear();system.displayBorrowingTools(loggedNverifiedMember);
                Console.Write("\nEnter anykey to continue.");Console.ReadKey();
            }
            else if (memSelection == "5")
            {
                Console.Clear();
                Console.WriteLine("-----------------Top 3 Borrowed Tools-----------------");
                system.displayTopThree();
                Console.WriteLine("----------------------------------------------------");
                Console.Write("\nEnter anykey to continue.");Console.ReadKey();
            }
            else
            {
                nameOfMember = "";
                BackToMainMenu(system);
            }

        }
    }
}