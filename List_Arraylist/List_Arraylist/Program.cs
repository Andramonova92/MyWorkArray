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
            List<int> list = new List<int>();
            ArrayList arraylist = new ArrayList();
            var a = GenerateInts(list,10);//заполнение list
             a = GenerateInts(list, 100);
             a = GenerateInts(list, 1000);
             a = GenerateInts(list, 10000);
             a = GenerateInts(list, 1000000);
           var b = GenerateArraylist(arraylist,10);//заполнение arraylist 
           b = GenerateArraylist(arraylist,100);
           b = GenerateArraylist(arraylist,1000);
           b = GenerateArraylist(arraylist,10000);
            b = GenerateArraylist(arraylist,1000000);
            DeleteInts(list);//удаление из list первого элемента
           DeleteArraylist(arraylist);//удаление из arraylist первого элемента
            
        }
        

        public static List<int> GenerateInts(List<int> list, int count)
        {
            Console.WriteLine("add to list {0}",count);
                for (int i = 0; i < count; i++)
                {
                    list.Add(i);

                }
               Stopwatch sw = Stopwatch.StartNew();
               Console.WriteLine("Время выполнения = {0}", sw.Elapsed);
               Console.ReadLine();
                return list;
        }
        public static ArrayList GenerateArraylist(ArrayList arraylist, int count) 
        
       {
           Console.WriteLine("add to arraylist {0}", count);
               for (int i = 0; i < count; i++)
               {
                   arraylist.Add(i);
               }
               Stopwatch sw = Stopwatch.StartNew();
               Console.WriteLine("Время выполнения = {0}", sw.Elapsed);
               Console.ReadLine();
               return arraylist;
        }

        
       public static void DeleteInts(List<int> list)
       {
           Console.WriteLine("количество элементов list {0}", list.Count);
           Stopwatch sw = Stopwatch.StartNew();
           list.RemoveAt(0);
           list.RemoveAt((list.Count-1)/2);
           list.RemoveAt(list.Count -1);
           Console.WriteLine("количество элементов list после удаления {0}",list.Count);
           Console.WriteLine("Время удаления из list = {0}", sw.Elapsed);
           Console.ReadLine();
           
       }

       public static void DeleteArraylist(ArrayList arraylist) 
       {
           Console.WriteLine("количество элементов arraylist {0}", arraylist.Count);
           int del = arraylist.Count;
           Stopwatch sw = Stopwatch.StartNew();
           arraylist.RemoveAt(0);
           arraylist.RemoveAt((arraylist.Count-1)/2);
           arraylist.RemoveAt(arraylist.Count -1);
           Console.WriteLine("количество элементов arraylist после удаления {0}", arraylist.Count);
           Console.WriteLine("Время удаления из arraylist = {0}", sw.Elapsed);
           Console.ReadLine();
           
       }
    }
}
