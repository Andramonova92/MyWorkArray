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
            List<int> list = new List<int>();
            ArrayList arraylist = new ArrayList();
            ListOrArraylist(count,list,arraylist);

        }
       
        List<int> list = new List<int>();
        ArrayList arraylist = new ArrayList();
        public static void ListOrArraylist(int count, List<int> list,ArrayList arraylist)
        {
            string elements;
            Console.WriteLine("Enter elements");
            elements = Console.ReadLine();

            string[] el = elements.Split(' ');


            for (int i = 0; i < 10; i++)
            {
                if (list.Count < 10)
                {
                    int m = int.Parse(el[i]);
                    list.Add(m);
                    // Console.WriteLine("list {0}", list.ElementAt<int>(i));
                    // Console.ReadKey();
                }

                else
                {
                    arraylist.AddRange(list);
                    
                    /* int m = int.Parse(el[i]);
                     list.Insert(i, m);
                    */

                }
                Console.WriteLine("list {0}", list.ElementAt<int>(i));
                Console.ReadKey();
                if (arraylist.Count == el.Length)
                {
                     foreach (int a in arraylist)
                    Console.WriteLine("arraylist {0}", a);

                    Console.ReadKey();
                }


            }
        }
        void FillArrayList(int i)
        {
            for (int iterator = i; i < el.Length; i++)
            {
                arraylist.Add(el[i]);
            }
        }
    }

}


        



    

 