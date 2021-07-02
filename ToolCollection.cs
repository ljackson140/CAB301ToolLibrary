using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301TOOL_LIBRARY
{
     class ToolCollection : iToolCollection
    {
        //============================================== private fields ====================================================================
       
       
        private Tool[] tPile;
        private int num;

        //identifies type of tool
        private readonly string idTool;
        public string Name 
        { 
            get { return idTool; } 
        }
        public int Number 
        { 
            get { return num; } 
        }


        //============================================== class constructor ====================================================================
        public ToolCollection(string idTool) {
            tPile = new Tool[num];
            this.idTool = idTool;
        }

        //============================================== Methods ====================================================================


        private int searchToolPos(Tool aTool) 
        {
            int i = 0;
            while( i < tPile.Length) 
            {
                if (tPile[i] != null && tPile[i].Name == aTool.Name)
                {
                    return i;
                }
                i++;
                break;
            }
            return -1;
        }

       
        private Tool[] arrResized(Tool[] arrOfTools) {
            
            List<Tool> listools = new List<Tool>();
            Tool[] arr = new Tool[num];

            if (num > arrOfTools.Length) 
            {
                
                for (int i = 0; i < arrOfTools.Length; i++)
                {
                    arr[i] = arrOfTools[i];
                }
            }
            else {
                foreach (Tool tool in arrOfTools) {
                    if (tool != null) {
                        listools.Add(tool);
                    }
                }
                arr = listools.ToArray();
            }
            return arr;
        }

       
        public void delete(Tool aTool)
        {
            int index = searchToolPos(aTool);
            if (index >=0) 
                tPile[index] = null;
                num--; tPile = arrResized(tPile);
        }

      
        public bool search(Tool aTool) 
        {
            if (searchToolPos(aTool) >= 0) { return true; }
            return false;
        }

        public void add(Tool aTool)
        {
            num++;
            tPile = arrResized(tPile);
            for (int i = 0; i < tPile.Length; i++)            
                if (tPile[i] == null)
                {
                    tPile[i] = aTool;
                    break;
                }
        }

        public Tool[] toArray()
        {
            return tPile;
        }
    }
}
