using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace List_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInts = new List<int>();
            ArrayList arraylist = new ArrayList();
            string[] el = new string[] { };
            //заполнение list arraylist
            Console.WriteLine("your enter");
            int count = int.Parse(Console.ReadLine());
            Stopwatch sw;//переменная для измерения затраченного времени на определнное действие
            sw = Stopwatch.StartNew();//установление значение времени равным нулю и запуск измерения
            var a = GenerateInts(count, myInts, el);
          Console.WriteLine("Your list {0}",a.Count);
            Console.WriteLine("List time {0}", sw.Elapsed);//вывод подсчитаного затраченного времени на заполнение

            sw = Stopwatch.StartNew();
            var b = GenerateArraylist(arraylist,count,el);
            Console.WriteLine("Your arraylist {0}",b.Count);
            Console.WriteLine("ArrayList time {0}", sw.Elapsed);
            Console.ReadLine();

            //добавление новых элементов в list arraylist
            Console.WriteLine("Enter element to add");
            string elements = Console.ReadLine();
            el = elements.Split(' ');
            sw = Stopwatch.StartNew();
            var add1 = GenerateInts(count,myInts,el);
            Console.WriteLine("New list count {0}", add1.Count);
            Console.WriteLine("List time of adding{0}", sw.Elapsed);

            sw = Stopwatch.StartNew();
            var add2 = GenerateArraylist(arraylist,count,el);
            Console.WriteLine("New arraylist count {0}", add2.Count);
            Console.WriteLine("Arrayist time of adding {0}", sw.Elapsed);
            // удаление элемента из list arraylist
            Console.WriteLine("Enter element to delete");
            int del = int.Parse(Console.ReadLine());
            sw = Stopwatch.StartNew();
            var deleteList = DeleteInts(myInts,del);
            Console.WriteLine("Count of List after delete {0}",deleteList.Count);
            Console.WriteLine("Deleted time list:{0}", sw.Elapsed);

            sw = Stopwatch.StartNew();
            var deleteArraylist = DeleteArraylist(arraylist, del);
            Console.WriteLine("Count of arraylist after delete {0}",deleteArraylist.Count);
            Console.WriteLine("Deleted time arraylist:{0}", sw.Elapsed);
            Console.ReadLine();
        }
        

        public static List<int> GenerateInts(int count,List<int> myInts, string[] el)
        {
            if (el.Length == 0)
            {
                for (int i = 0; i < count; i++)
                {
                    myInts.Add(i);

                }
            }
            if (el.Length > 0)
            {
                for (int j = 0; j < el.Length; j++)
                {
                    int e = int.Parse(el[j]);
                    myInts.Add(e);
                }
            }
                return myInts;
        }
        public static ArrayList GenerateArraylist(ArrayList arraylist, int count, string[] el) 
        
       {
           if (el.Length == 0)
           {
               for (int i = 0; i < count; i++)
               {
                   arraylist.Add(i);
               }
           }
           if (el.Length > 0) 
           {
               for (int j = 0; j < el.Length; j++) 
               {
                   int e = int.Parse(el[j]);
                   arraylist.Add(e);
               }
           }
               return arraylist;
        }

        
       public static List<int> DeleteInts(List<int> myInts,int del)
       {
           myInts.RemoveAt(del);
           return myInts;
       }

       public static ArrayList DeleteArraylist(ArrayList arraylist, int del) 
       {
           arraylist.RemoveAt(del);
           return arraylist;
       }
    }
}
