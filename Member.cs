using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace CAB301TOOL_LIBRARY
{
    class Member : iMember, IComparable<Member>
    {
        //============================================== private fields ====================================================================

        //Member fields 
        private string fName;
        private string lName;
        private string cNumber;
        private string pIN;

        //global fields 
        private string[] tNames;
        private int nBTools;
        private ToolCollection toolsBorrowed;

        //============================================== class Constructor ====================================================================
        public Member(String fName, String lName, string cNumber, String pIN)
        {
            toolsBorrowed = new ToolCollection("Borrowed Tools");
            this.FirstName = fName;
            this.LastName = lName;
            this.ContactNumber = cNumber;
            this.PIN = pIN;

        }


        //============================================== property fields ====================================================================
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string ContactNumber
        {
            get { return cNumber; }
            set { cNumber = value; }
        }

        public string PIN
        {
            get { return pIN; }
            set { pIN = value; }
        }
        public string[] Tools
        {
            get
            {
                tNames = new string[nBTools];

                for (int j = 0; j < toolsBorrowed.toArray().Length; j++)
                {
                    if (toolsBorrowed.toArray()[j] != null)
                    {
                        tNames[j] = toolsBorrowed.toArray()[j].Name;
                    }
                    
                }
                return tNames;
            }

        }



       

        //============================================== Methods ====================================================================
        //*
        //Resize Array
        //param arrayOfToolNames
        //takes a string array
        //returns new modified array*//
        private string[] arrResized(string[] arrayOfToolNames)
        {
            string[] outPut = new string[nBTools];

            if (nBTools > arrayOfToolNames.Length)
            {
                for (int j = 0; j < arrayOfToolNames.Length; j++)
                {
                    tNames[j] = arrayOfToolNames[j];
                    
                }
            }
            else {
                outPut = outPut.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            }
            return outPut;
        }



        public void addTool(Tool aTool)
        {
            nBTools++;
            tNames = arrResized(tNames);
            toolsBorrowed.add(aTool);
        }

        //comparison of members
        public int CompareTo(Member user)
        {
            if (lName.CompareTo(user.lName) < 0 || lName.CompareTo(user.lName) == 0 && fName.CompareTo(user.fName) < 0) { return -1; }
            else if (lName.CompareTo(user.lName) == 0 && fName.CompareTo(user.fName) == 0) { return 0; }
            else { return 1; }
        }


        public void deleteTool(Tool aTool)
        {
            nBTools--;
            tNames = arrResized(tNames);
            toolsBorrowed.delete(aTool);
        }


        public override string ToString()
        {
            return String.Format("{0, -25}{1, -25} {2, -25}", fName, lName, cNumber);
        }

    }
}
