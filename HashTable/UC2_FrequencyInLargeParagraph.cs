using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class UC2_FrequencyInLargeParagraph
    {   
        public void frequency()
        {
            string str = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr = str.Split(" ");
            int size = arr.Length;
            MyMapNode<string, string> hash = new MyMapNode<string, string>(size - 1);
            foreach (var s in arr)
            {
                if (hash.Get(s)!=null)
                {
                    int k = Convert.ToInt32(hash.Get(s));
                    k++;
                    hash.Remove(s);
                    hash.Add(s, k.ToString());
                }
                else
                {
                    hash.Add(s, "1");
                    
                }
            }

            printValues(arr, size, hash);
        }
        private static void printValues(string[] arr, int size, MyMapNode<string, string> hash)
        {
            Console.WriteLine("Frequency    Word");
            for (int i = 0; i < size; i++)
            {
                string result = "  " + hash.Get(arr[i]) + "          " + arr[i];
                int j;
                for (j = 0; j < i; j++)
                    if (arr[i] == arr[j])
                        break;
                if (i == j)
                    Console.Write("{0}\n", result);
            }
        }
    }
}
