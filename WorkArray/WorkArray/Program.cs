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

        public static void ListAndArraylist(int count)
        {

            List<int> list = new List<int>();
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Enter elements");
            string addElement = Console.ReadLine();
            string[] Elements = addElement.Split(' ');

            for (int i = 0; i < count; i++)
            {
                int m = int.Parse(Elements[i]);
                list.Insert(i, m);
                arraylist.Insert(i, m);
            }
            foreach (int l in list)
                Console.WriteLine("list {0}", l);
            Console.WriteLine("\n");

            foreach (int a in arraylist)
                Console.WriteLine("arraylist {0}", a);
            Console.ReadKey();
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
                int m = int.Parse(el[i]);
                list.Insert(i, m);

                if (list.Count > count)
                {
                    ArrayList arraylist = new ArrayList(list);
                   foreach (int a in arraylist)

                        Console.WriteLine("arraylist {0}", a);
                    Console.ReadKey();
                }

            }
            foreach (int l in list)
                Console.WriteLine("list {0}", l);
            Console.ReadKey();


        }

    }

}
        



    

 