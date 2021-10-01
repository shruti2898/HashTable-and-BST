using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class UC3_RemoveWord
    {
        public void removeWord(string word)
        {
            string str = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr = str.Split(" ");
            int size = arr.Length;
            MyMapNode<string, string> hash = new MyMapNode<string, string>(size - 1);
            for( int i = 0; i < size; i++)
            {
                hash.Add(arr[i], i.ToString());
            }
            for (int i = 0; i < size; i++)
            {
                hash.Add(arr[i], i.ToString());
            }

           
            hash.Remove(hash.Get(word));
            

        }
        

    }
}
