using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace cab301Assignment
{
    class Tool : iTool, IComparable<Member>
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AvailableQuantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NoBorrowings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public iMemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
