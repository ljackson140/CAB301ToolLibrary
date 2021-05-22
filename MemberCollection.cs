using System;
using System.Collections.Generic;
using System.Text;

namespace cab301Assignment
{
    public class MemberCollection : iMemberCollection
    {
        private BinarySearchTree collectionOfMembers = new BinarySearchTree();
        private int num;


        public int Number
        {
            get { return num; }
        }

        public void add(Member aMember)
        {
            collectionOfMembers.Insert(aMember);
            ++num;
        }

        public void delete(Member aMember)
        {
            collectionOfMembers.Delete(aMember);
            --num;
        }

        public bool search(Member aMember)
        {
            throw new NotImplementedException();
        }

        public Member[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
