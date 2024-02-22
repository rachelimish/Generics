using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SwapList<T> : List<T>
    {
        public void Swap(int ind1, int ind2)
        {
            T temp =this[ind1];
            this[ind1] = this[ind2];
            this[ind2] = temp;
        }
    }
   public class Program
    {
       public static void Main(string[] args)
        {   
            int x = 8;
            PrintTheObj<int>(x);
            Console.WriteLine();
            double y = 152.123;
            PrintTheObj<double>(y);
            Console.WriteLine();
            SwapList<string> listofname = new SwapList<string>() { "racheli", "tamar", "rivka" };
            listofname.Swap(1,2);
            foreach (string i in listofname)
            {
                Console.Write(i+",");
            }
            Console.Read();
        }
        static void PrintTheObj<T>(T obj)
        {
            Console.WriteLine(obj);
        }

    }
}
