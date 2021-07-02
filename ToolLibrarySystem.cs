using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAB301TOOL_LIBRARY
{
    class ToolLibrarySystem : iToolLibrarySystem
    {

        //============================================== private fields ====================================================================
        
        //tool collection
        private ToolCollection[] tPile;
        //borrowed tools
        private List<Tool> listBorrTools;
        //array of borrowed tools
        private Tool[] arrBorrowedTools;
        //members
        private MemberCollection members;

        //============================================== class constructor ====================================================================
        public ToolLibrarySystem()
        {
            tPile = Displays.fetchallTCs();
            members = Displays.allMemCollection();
            listBorrTools = new List<Tool>();
        }


       
        public void add(Tool aTool)
        {
            int ovlength = tPile.Length;
            for (int k = 0; k < ovlength; k++)            
                if (tPile[k].Name == Displays.fetchCurrToolType())
                {
                    tPile[k].add(aTool);
                }
        }

       
        public void add(Tool aTool, int quantity)
        {
            aTool.Quantity += quantity;
            aTool.AvailableQuantity += quantity;
        }

        public void delete(Tool aTool, int quantity)
        {
            aTool.AvailableQuantity -= quantity;
            aTool.Quantity -= quantity;
        }

        public bool borrowTool(Member aMember, Tool aTool)
        {
            if (aTool.AvailableQuantity > 0)            
                if (aMember.Tools == null || aMember.Tools.Length < 3) {
                    aMember.addTool(aTool);
                    aTool.addBorrower(aMember);
                    listBorrTools.Add(aTool);
                    listBorrTools = listBorrTools.Distinct().ToList();
                    arrBorrowedTools = listBorrTools.ToArray(); 
                    return true;
                }
                else {
                    Console.WriteLine("" +
                        "\nExceeded borrowing limit (3), please return some back to continue borrowing tools." +
                        "\nPress anykey to continue. ");
                    Console.ReadKey();
                }
            else            
                Console.WriteLine("" +
                    "\nTool unavailable, please come back later." +
                    "\nPress anykey to continue. ");
                Console.ReadKey();
            return false;
        }

       //bubblesort sort method to delete 
        //a tool in the collection
        public void delete(Tool aTool)
        {
            for (int n = 0; n < tPile.Length; n++)            
                for (int m = 0; m < tPile[n].toArray().Length; m++)                
                    if (aTool.Name == tPile[n].toArray()[m].Name)
                    {
                        tPile[n].delete(aTool);
                    }
        }

      
        public void delete(Member member)
        {
            int tnum = member.Tools.Length;
            if (member.Tools != null && tnum > 0)
            {
                Console.WriteLine("" +
                    "\nUnable to delete this member! Member is currently borrowing a tool." +
                    "\nPress anykey to continue.");
                Console.ReadKey();
            }
            else            
                members.delete(member);
                Console.WriteLine(
                    "\n" + member.FirstName + " " + member.LastName + " has been successfully removed. " +
                    "\nPress anykey to continue.");
                Console.ReadKey();
            
        }

       
        public void displayTools(string aToolType)
        {
            string header = "-----------------------" + aToolType + "-----------------------";
            Console.WriteLine(header);
            Console.WriteLine("   {0, -20}{1, -13}{2, -8}{3, -8}", "Name", "Available", "Total", "Total Borrowings");
            int pile = tPile.Length;
            int tlen = header.Length;
            for (int i = 0; i < pile; i++)
            {
                if (tPile[i].Name == aToolType) {
                    for (int m = 0; m < tPile[i].Number; m++){
                        Tool tool = tPile[i].toArray()[m];
                        Console.WriteLine(m + 1 + ". " + tool.ToString());
                    }
                    break;
                }                 
            }
            for (int i = 0; i < tlen; i++)            
                Console.Write("=");            
            Console.WriteLine();
        }




       //Bubble sort algorithm :)
       //displays Top 3 tools that were borrowed 
        public void displayTopThree()
        {
            int numBorrowTs = arrBorrowedTools.Length;

            for (int i = 0; i < 3 - 1; i++)    
            {
                int largest = i;
                for (int j = i + 1; j < numBorrowTs; j++)
                {
                    if (arrBorrowedTools[j].NoBorrowings < arrBorrowedTools[largest].NoBorrowings)
                    {
                        largest = j;
                    }
                }
                if (largest != 1)
                {
                    Tool temp = arrBorrowedTools[largest];
                    arrBorrowedTools[largest] = arrBorrowedTools[i];
                    arrBorrowedTools[i] = temp;
                }
            }


            if (arrBorrowedTools[^1].NoBorrowings > 0)
            {
                Console.WriteLine("\n" +
                    "{0, -25}  Max Borrowings: {1, -20}", arrBorrowedTools[^1].Name, arrBorrowedTools[^1].NoBorrowings);

            }
                
            if (numBorrowTs > 1 && arrBorrowedTools[^2].NoBorrowings > 0)
            {
                Console.WriteLine("\n" +
                    "{0, -25}  Total Borrowings: {1, -20}", arrBorrowedTools[^2].Name, arrBorrowedTools[^2].NoBorrowings);

            }

            if (numBorrowTs > 2 && arrBorrowedTools[^3].NoBorrowings > 0)
            {
                Console.WriteLine("\n" +
                    "{0, -15}  Total Borrowings: {1, -20}", arrBorrowedTools[^3].Name, arrBorrowedTools[^3].NoBorrowings);

            }
        }
       
        public void returnTool(Member aMember, Tool aTool)
        {
            aMember.deleteTool(aTool);
            aTool.deleteBorrower(aMember);
        }

        public string[] listTools(Member aMember)
        {
            return aMember.Tools;
        }


        public void displayBorrowingTools(Member aMember)
        {
            Console.WriteLine("-----------------------Borrowed Tools-----------------------");
            if (aMember.Tools != null)
            {
                int len = aMember.Tools.Length;
                for (int i = 0; i < len; i++)                
                    Console.WriteLine(i + 1 + ". " + aMember.Tools[i]);
            }
            Console.WriteLine("--------------------------------------------------------");
        }

        public void add(Member aMember)
        {
            members.add(aMember);
        }

        static void Main(string[] args)
        {
            ToolLibrarySystem CommunityLibrarySystem = new ToolLibrarySystem();
            string MainMenuOptions = Displays.MainMenuScreen();
            Displays.RunMainMenu(MainMenuOptions, CommunityLibrarySystem);
        }
    }
}
