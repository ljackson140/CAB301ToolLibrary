using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace cab301Assignment
{
    public class Member : iMember, IComparable<Member>
    {
        private string fName;
        private string lName;
        private string cNumber;
        private string pIN;

        public string FirstName {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName {
            get { return lName; }
            set { lName = value; }
        }
        public string ContactNumber {
            get { return cNumber; }
            set { cNumber = value; }
        }
        public string PIN {
            get { return pIN; }
            set { pIN = value; }
        }

        Tool[] Tools
        {
            get { return tools.toArray(); }
        }

       

        public void addTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
