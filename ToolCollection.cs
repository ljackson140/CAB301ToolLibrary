using System;
using System.Collections.Generic;
using System.Text;

namespace cab301Assignment
{
    class ToolCollection : iToolCollection
    {
        private Tool[] collection = new Tool[40];
        private int num;
        public int Number {
            get { return num; }
        }

        public void add(Tool aTool)
        {
            for (int i = 0; i < collection.Length; ++i)
                if (collection[i] == null)
                {                                                                                 
                    collection[i] = aTool;
                    break;
                }
            ++num;
        }

        public void delete(Tool aTool)
        {
            for (int i = 0; i < collection.Length; ++i)
                if (collection[i] == aTool)
                {
                    collection[i] = null;
                    break;
                }
            --num;
        }

        public bool search(Tool aTool)
        {
            for (int i = 0; i < Number; ++i)
                if (collection[i].Equals(aTool))
                    return true;
            return false;
        }

        public Tool[] toArray()
        {
            Tool[] rArray = new Tool[Number];
            int tIdx = 0;
            for (int i = 0; i < collection.Length; ++i)
                if (collection[i] != null)
                {
                    rArray[tIdx] = collection[i];
                    ++tIdx;
                }
            return rArray;

        }
    }
}
