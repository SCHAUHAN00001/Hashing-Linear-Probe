using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_Linear_Probe
{
    internal class Program
    {
        class HashLinear_Prob
        {
            int hashtablesize;
            int[] hashtable;
            public HashLinear_Prob()
            {
                hashtablesize = 10;
                hashtable = new int[hashtablesize];
            }
            public int hashcode(int key)
            {
                return key % hashtablesize;
            }
            public int lprob(int elemnet)
            {
                int i = hashcode(elemnet);
                int j = 0;
                while (hashtable[(i+j) % hashtablesize] != 0)
                {
                    j = j + 1;
                }
                return (i + j) % hashtablesize;
            }
            public void insert(int element)
            {
                int i = hashcode(element);
                if (hashtable[i] == 0) 
                {
                    hashtable[i] = element;
                }
                else
                {
                    i = lprob(element);
                    hashtable[i] = element;
                }
            }
            public bool search(int key)
            {
                int i = hashcode(key);
                int j = 0;
                while (hashtable[(i + j) % hashtablesize] != key)
                {
                    if (hashtable[(i + j) % hashtablesize] == 0)
                    {
                        return false;
                    }
                    j = j + 1;
                }
                return true;    

            }
            public void display()
            {
                for(int i = 0;i<hashtablesize;i++)
                {
                    Console.WriteLine(hashtable[i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            HashLinear_Prob H = new HashLinear_Prob();
            H.insert(41);
            H.insert(52);
            H.insert(68);
            H.insert(28);
            
           H.display();
            Console.ReadLine();
        }
    }
}
