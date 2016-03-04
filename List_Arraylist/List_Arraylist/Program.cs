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
            int deleteIndex = 1;
            Stopwatch sw;//переменная для измерения затраченного времени на определнное действие
            sw = Stopwatch.StartNew();//установление значение времени равным нулю и запуск измерения
            var a = GenerateInts(myInts,10);
            Console.WriteLine("Your list {0}",a.Count);
            Console.WriteLine("time to add a 10 element in list {0}", sw.Elapsed);//вывод подсчитаного затраченного времени на заполнение
            var b = GenerateArraylist(arraylist,10);
           Console.WriteLine("Your arraylist {0}",b.Count);
            Console.WriteLine("time to add a 10 element in arraylist {0}", sw.Elapsed);
            myInts.Clear();
            arraylist.Clear();
            Console.WriteLine("\n");

            sw = Stopwatch.StartNew();
            var c = GenerateInts(myInts, 100);
           Console.WriteLine("Your list {0}",c.Count);
            Console.WriteLine("time to add a 100 element in list {0}", sw.Elapsed);
            var d = GenerateArraylist(arraylist, 100);
           Console.WriteLine("Your arraylist {0}",d.Count);
            Console.WriteLine("time to add a 100 element in arraylist {0}", sw.Elapsed);
            myInts.Clear();
            arraylist.Clear();
            Console.WriteLine("\n");

            sw = Stopwatch.StartNew();
            var e = GenerateInts(myInts, 1000);
             Console.WriteLine("Your list {0}",e.Count);
            Console.WriteLine("time to add a 1000 element in list {0}", sw.Elapsed);
            var f = GenerateArraylist(arraylist, 1000);
             Console.WriteLine("Your arraylist {0}",f.Count);
            Console.WriteLine("time to add a 1000 element in arraylist {0}", sw.Elapsed);
            myInts.Clear();
            arraylist.Clear();
            Console.WriteLine("\n");

            sw = Stopwatch.StartNew();
            var g = GenerateInts(myInts, 10000);
             Console.WriteLine("Your list {0}",g.Count);
            Console.WriteLine("time to add a 10000 element in list {0}", sw.Elapsed);
            var h = GenerateArraylist(arraylist, 10000);
             Console.WriteLine("Your arraylist {0}",h.Count);
            Console.WriteLine("time to add a 10000 element in arraylist {0}", sw.Elapsed);
            myInts.Clear();
            arraylist.Clear();
            Console.WriteLine("\n");

            sw = Stopwatch.StartNew();
            var k = GenerateInts(myInts, 100000);
            Console.WriteLine("Your list {0}",k.Count);
            Console.WriteLine("time to add a 100000 element in list {0}", sw.Elapsed);
            var l = GenerateArraylist(arraylist, 100000);
            Console.WriteLine("Your arraylist {0}",l.Count);
            Console.WriteLine("time to add a 100000 element in arraylist {0}", sw.Elapsed);
            Console.WriteLine("\n");

            sw = Stopwatch.StartNew();
            var m = DeleteInts(myInts,deleteIndex);
            Console.WriteLine("Delete one element");
            Console.WriteLine("Your list {0}", m.Count);
            Console.WriteLine("time to delete in list {0}", sw.Elapsed);
            var n = DeleteArraylist(arraylist,deleteIndex);
            Console.WriteLine("Your arraylist {0}", n.Count);
            Console.WriteLine("time to delete  in arraylist{0}", sw.Elapsed);
            Console.ReadLine();
        }
        

        public static List<int> GenerateInts(List<int> myInts, int count)
        {
            
                for (int i = 0; i < count; i++)
                {
                    myInts.Add(i);

                }

                return myInts;
        }
        public static ArrayList GenerateArraylist(ArrayList arraylist, int count) 
        
       {
               for (int i = 0; i < count; i++)
               {
                   arraylist.Add(i);
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
