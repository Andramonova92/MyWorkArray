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
        static void Main(string[] args)
        {
            int count=10;
            ListOrArraylist(count);
        }


        public static void ListOrArraylist(int count)
        {
            string elements;
            List<int> list = new List<int>();
            Console.WriteLine("Enter elements");
            elements = Console.ReadLine();
            string[] el = elements.Split(' ');

            
            if (el.Length <= count)
            {
                for (int i = 0; i < count; i++)
                {
                    int m = int.Parse(el[i]);
                    list.Insert(i, m);
                }
                foreach (int l in list)
                    Console.WriteLine("list {0}", l);
                Console.ReadKey();
            }


            else
            {
                ArrayList arraylist = new ArrayList();
                for (int i = 0; i < el.Length; i++)
                {
                    int m = int.Parse(el[i]);
                    arraylist.Insert(i, m);

                }
                foreach (int a in arraylist)
                    Console.WriteLine("arraylist {0}", a);
                Console.ReadKey();
            }  
            }
        }
    }

    

 