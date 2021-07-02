// File: BTree.cs
// An implementation of BTree ADT
// Maolin Tang 
// 24/3/06
//Taken from week 5 BST workshop 

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CAB301TOOL_LIBRARY;

namespace CAB301TOOL_LIBRARY
{
    class MemberCollection : iMemberCollection, iBinarySearchTree
	{
		//============================================== private fields ====================================================================
		private int num;
		private BTreeNode root;

		//============================================== class constructor ====================================================================
		public MemberCollection()
		{
			root = null;
		}

		//============================================== property fields ====================================================================
		public int Number 
		{ 
			get { return num; } 
			set { num = value; } 
		}

		
		

		// pre: ptr != null
		// post: item is inserted to the binary search tree rooted at ptr
		private void insert(Member aMember, BTreeNode ptr)
		{
			if (aMember.CompareTo(ptr.Member) < 0)
			{
				if (ptr.LChild == null)
					ptr.LChild = new BTreeNode(aMember);
				else
				{
					insert(aMember, ptr.LChild);
				}
			}
			else
			{
				if (ptr.RChild == null)
					ptr.RChild = new BTreeNode(aMember);
				else
				{
					insert(aMember, ptr.RChild);
				}
			}
		}

		

		//deletion of member in collection
		public void delete(Member aMember)
		{
			// search for item and its parent
			BTreeNode ptr = root; // search reference
			BTreeNode parent = null; // parent of ptr
			while ((ptr != null) && (aMember.CompareTo(ptr.Member) != 0))
			{
				parent = ptr;
				if (aMember.CompareTo(ptr.Member) < 0) // move to the left child of ptr
					ptr = ptr.LChild;
				else
					ptr = ptr.RChild;
			}

			if (ptr != null) // if the search was successful
			{
				num--;
				// case 3: item has two children
				if ((ptr.LChild != null) && (ptr.RChild != null))
				{
					// find the right-most node in left subtree of ptr
					if (ptr.LChild.RChild == null) // a special case: the right subtree of ptr.LChild is empty
					{
						ptr.Member = ptr.LChild.Member;
						ptr.LChild = ptr.LChild.LChild;
					}
					else
					{
						BTreeNode p = ptr.LChild;
						BTreeNode pp = ptr; // parent of p
						while (p.RChild != null)
						{
							pp = p;
							p = p.RChild;
						}
						// copy the item at p to ptr
						ptr.Member = p.Member;
						pp.RChild = p.LChild;
					}
				}
				else // cases 1 & 2: item has no or only one child
				{
					BTreeNode c;
					if (ptr.LChild != null)
						c = ptr.LChild;
					else
						c = ptr.RChild;

					// remove node ptr
					if (ptr == root) //need to change root
						root = c;
					else
					{
						if (ptr == parent.LChild)
							parent.LChild = c;
						else
							parent.RChild = c;
					}
				}

			}
		}


		
		public bool search(Member aMember)
		{
			return Search(aMember, root);
		}

		private bool Search(Member item, BTreeNode r)
		{
			if (r != null)
			{
				if (item.CompareTo(r.Member) == 0)
					return true;
				else
					if (item.CompareTo(r.Member) < 0)
					return Search(item, r.LChild);
				else
					return Search(item, r.RChild);
			}
			else
				return false;
		}



		Member[] arrOfMembers = new Member[1000]; 
		int pos = 0; 

		
		public Member[] toArray()
		{
			arrOfMembers = new Member[1000]; 
			pos = 0;                    
			InOrderTraverse(root);
			return arrOfMembers;
		}

		//same as BST => INSERT()
		public void add(Member member)
		{
			num++;
			if (root == null)
				root = new BTreeNode(member);
			else
				insert(member, root);
		}

		private Member[] InOrderTraverse(BTreeNode root)
		{

			if (root != null)
			{
				InOrderTraverse(root.LChild);
			    arrOfMembers[pos++] = root.Member;
				InOrderTraverse(root.RChild);
			}

			return arrOfMembers;
		}

        bool iBinarySearchTree.IsEmpty()
        {
            throw new NotImplementedException();
        }

        void iBinarySearchTree.Clear()
        {
            throw new NotImplementedException();
        }
    }
}
