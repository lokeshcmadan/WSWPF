using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Collections are of 6 types ArrayList, HashTable, SortedList, Stacklist, Queue List and BitArray*/



            //ArrayList al = new ArrayList();
            //al.Add("India");
            //al.Add("Japan");
            //al.Add("USA");
            //al.Insert(1, "UK");
            //al.Add("Aus");
            //Console.WriteLine("Capacity of ArrayList:" + al.Capacity);
            //Console.WriteLine("Number Of Elements:"+al.Count);
            //foreach (string  i in al)
            //{
            //    Console.Write(i + " ");
            //}


            //Hashtable ht = new Hashtable();
            //ht.Add("001", "India");
            //ht.Add("002","USA");
            //ht.Add("003","UK");
            //ICollection key = ht.Keys;
            //foreach (string s in key)
            //{
            //    Console.WriteLine(s + " " + ht[s]);
            //}
            //Stack st = new Stack();
            //st.Push('A');
            //st.Push('B');
            //foreach (char ch in st)
            //{
            //    Console.WriteLine(ch);0
            //}
            //st.Pop();
            //Console.WriteLine("Stack Elements after Popping");
            //foreach (char ch in st)
            //{
            //    Console.WriteLine(ch);
            //}
            int[,] x = new int[2, 2]
                {
                    { 10,20},
                    { 30,40},
                };
            int[,] z = new int[2, 2]
                {
                    { 50,60},
                    { 70,80},
                };
            Queue qe = new Queue();
            qe.Enqueue(x);
            qe.Enqueue(z);
            //for(int i=0;i<x.GetLength(0);i++)
            //{
            //    for(int j=0;j<x.GetLength(1);j++)
            //    {
            //        qe.Enqueue(x[i,j]);
            //   }
            //}
            foreach (int [,] y in qe)
            {
                for (int i = 0; i < x.GetLength(0); i++)
                    {
                       for(int j=0;j<x.GetLength(1);j++)
                       {
                        Console.Write(y[i,j]+" ");
                       }
                    Console.WriteLine();
                   }
                
            }
            Console.WriteLine("Queue after Deleting Elements");
            qe.Dequeue();
            foreach (int[,] y in qe)
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    for (int j = 0; j < x.GetLength(1); j++)
                    {
                        Console.Write(y[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();   
        }
    }
}
