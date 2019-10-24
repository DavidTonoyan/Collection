using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tveri xumb

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(100);
            list.Add(500);
            list.Add(800);
            list.Add(450);
            list.Add(965);
            list.Add(145);
            list.Add(189);
            list.Add(178);

            //Sortavorum

            list.Sort();
          
            //Tpum e tvery yst achman kargi
            
            foreach (int value in list)
            {
                Console.WriteLine(value + " ");
            }
            AAA:
            //Tvi mutqagrum
            Console.Write("Greq dzer tivy-----------");
            int num =Int32.Parse(Console.ReadLine());

            list.Add(num);
           //Sortavorum avelacvac tvov
            list.Sort();
            foreach (int value in list)
            {
                Console.WriteLine(value + " ");
            }
           
             Console.WriteLine("Uzum eq tiv avelacnel?");
            string a = Console.ReadLine().ToLower();

            if (a == "ayo" || a=="a")
            {
                goto AAA;
            }
            

           




        }

    }

}
