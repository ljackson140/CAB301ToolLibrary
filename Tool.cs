using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CAB301TOOL_LIBRARY
{
    class Tool : iTool
    {
        //============================================== private fields ====================================================================

        //tool fields 
        private string title;
        private int quantity;
        private int vacantAmount;

        //borrow fields
        private MemberCollection memsWthTool;
        private int borrInvalid;

        //============================================== class constructor ====================================================================
        public Tool(string title)
        {
            memsWthTool = new MemberCollection();
            this.title = title;
        }


        //============================================== Properties ====================================================================
        public string Name 
        { 
            get { return title; } 
            set { title = value; } 
        }
        public int Quantity 
        { 
            get { return quantity; } 
            set { quantity = value; } 
        }
        public int AvailableQuantity 
        { 
            get { return vacantAmount; } 
            set { vacantAmount = value; } 
        }
        public int NoBorrowings 
        { 
            get { return borrInvalid; } 
            set { borrInvalid = value; } 
        }
        public MemberCollection GetBorrowers 
        {
            get { return memsWthTool; } 
        }

       

        //============================================== Methods ====================================================================


        public void deleteBorrower(Member aMember)
        {
            memsWthTool.delete(aMember);
            vacantAmount++;
        }

        public void addBorrower(Member aMember)
        {
            if (vacantAmount > 0)            
                memsWthTool.add(aMember);
                borrInvalid++;
                vacantAmount--;
        }

       
             
        public override string ToString()
        {
            var msg = String.Format("{0, -25}{1, -14}{2, -10}{3, -10}", title, vacantAmount, quantity, borrInvalid);
            return msg;
        }
    }
}
