using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WorkArray
{
    class Program
    {
        public static void Main(string[] args)
        {

            int count = 10;
            ListOrArraylist(count);
        }

        public static void ListOrArraylist(int count)
        {
            string elements;
            List<int> list = new List<int>();
            
            Console.WriteLine("Enter elements");
            elements = Console.ReadLine();

            string[] el = elements.Split(' ');

          
            for (int i = 0; i < el.Length; i++)
            {
                if (list.Count < 10)
                {
                    int m = int.Parse(el[i]);
                    list.Insert(i, m);
                    Console.WriteLine("list {0}", list.ElementAt<int>(i));
                    Console.ReadKey();
                }

                else
                {
                    int m = int.Parse(el[i]);
                    list.Insert(i, m);
                    ArrayList arraylist = new ArrayList(list);
                   foreach (int a in arraylist)
                        Console.WriteLine("arraylist {0}", a);
                    Console.ReadKey();
                }
            }

        }

    }

}
        



    

 