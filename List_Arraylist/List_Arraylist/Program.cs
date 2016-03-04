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
            var c = DeleteInts(list, 0);//удаление из list первого элемента
            c = DeleteInts(list, (list.Count/2));//удаление элемента в середине
            c = DeleteInts(list,(list.Count-1));//удаление последнего элемента
            var d = DeleteArraylist(arraylist,0);//удаление из arraylist первого элемента
            d = DeleteArraylist(arraylist, (arraylist.Count/2));//удаление элемента в середине
            d = DeleteArraylist(arraylist, (arraylist.Count-1));//удаление последнего элемента
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

        
       public static List<int> DeleteInts(List<int> list,int del)
       {
           Console.WriteLine("количество элементов list {0}", list.Count);
           Stopwatch sw = Stopwatch.StartNew();
           list.RemoveAt(del);
           
           Console.WriteLine("количество элементов list после удаления {0}",list.Count);
           Console.WriteLine("Время удаления из list = {0}", sw.Elapsed);
           Console.ReadLine();
           return list;
       }

       public static ArrayList DeleteArraylist(ArrayList arraylist, int del) 
       {
           Console.WriteLine("количество элементов arraylist {0}", arraylist.Count);
           Stopwatch sw = Stopwatch.StartNew();
           arraylist.RemoveAt(del);
           Console.WriteLine("количество элементов arraylist после удаления {0}", arraylist.Count);
           Console.WriteLine("Время удаления из arraylist = {0}", sw.Elapsed);
           Console.ReadLine();
           return arraylist;
       }
    }
}
