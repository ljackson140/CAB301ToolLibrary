using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301TOOL_LIBRARY
{
    
	// invariants: every node’s left subtree contains values less than or equal to 
	// the node’s value, and every node’s right subtree contains values 
	// greater than or equal to the node’s value
	interface iBinarySearchTree
	{
		// pre: true
		// post: return true if the binary tree is empty; otherwise, return false.
		bool IsEmpty();

		// pre: true
		// post: an occurrence of item is removed from the binary search tree 
		//		 if item is in the binary search tree
		void delete(Member item);

		// pre: true
		// post: return true if item is in the binary search true;
		//	     otherwise, return false.
		bool search(Member item);

		// pre: true
		// post: item is added to the binary search tree
		void add(Member item);

		// pre: true
		// post: all the nodes in the binary tree are removed and the binary tree becomes empty
		void Clear();

	}
	
}
