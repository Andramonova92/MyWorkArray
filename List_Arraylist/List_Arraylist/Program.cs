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
            ArrayList Arraylist = new ArrayList();
            List<int> List = new List<int>();
            int[] myInts = new int[25];
            ListOrArraylist(Arraylist, List, myInts);
        }

     
        static void ListOrArraylist(ArrayList arraylist, List<int> list,int[] myints) 
        {
          Random ran = new Random();
        for (int i = 0; i < 10; i++)
        {
        if (i<10)
        {
            myints[i] = ran.Next(1,25);
            list.Add(myints[i]);
        }
        arraylist.AddRange(list);
        FillArrayList(i, arraylist, myints);
}
        Console.WriteLine("Your enter");
        Console.ReadLine();
            foreach(int l in list)
        Console.WriteLine("list {0}",l);
           Console.WriteLine("arraylist {0}", arraylist.Count);
            Console.ReadKey();
                
        }
       static void FillArrayList(int i,ArrayList arraylist,int[] myints) 
        {
            for (int j = i; i < myints.Length; i++)
            {
                
                arraylist.Add(myints[i]);
                
            }
           
        }
    }
}
