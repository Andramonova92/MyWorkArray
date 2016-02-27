using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInts = new List<int>();
            Console.WriteLine("your enter");
            int count = int.Parse(Console.ReadLine());
            var a = GenerateInts(count,myInts);
            Console.WriteLine("Your list");
            foreach(int e in a)
            Console.WriteLine(e);
            Console.ReadLine();


            Console.WriteLine("Enter ints to add");
            string elements = Console.ReadLine();
            string[] el = elements.Split(' ');
            var add = AddInts(myInts,el);
            foreach(int c in add)
            Console.WriteLine(c);
            Console.ReadLine();

            Console.WriteLine("Enter element to delete");
            int del = int.Parse(Console.ReadLine());
            var delete = DeleteInts(myInts,del,count);
            foreach(int d in delete)
            Console.WriteLine(d);
            Console.ReadLine();
        }
        

        public static List<int> GenerateInts(int count,List<int> myInts)
        {
            for (int i = 0; i < count; i++)
            {
                myInts.Add(i);
                
            }
            return myInts;
           
        }
        public static List<int> AddInts(List<int> myInts,string[] el)
        {
            for (int i = 0; i < el.Length;i++ ) {
                int j = int.Parse(el[i]);
                myInts.Add(j);
            }
            return myInts;
        }

       public static List<int> DeleteInts(List<int> myInts,int del, int count)
       {
           

               myInts.RemoveAll(delegate(int i)
               {
                   return i==del;
               });
           

           return myInts;
       }
      
    }
}
