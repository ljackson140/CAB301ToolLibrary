using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace cab301Assignment
{
    public class Member : iMember, IComparable<Member>
    {
        public Member(String fName, String lName, string contactNumber, String Pin)
        {

        }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PIN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] Tools => throw new NotImplementedException();

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
