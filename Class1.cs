using System;
using System.Collections;
namespace Collections
{
    class Humans:IEnumerable
    {
        private string[] names = new string[5];

        private int[] ages = new int[5];

        public Humans()
        {
            names[0] = "Ani";
            ages[0] = 10;
            names[1] = "Mane";
            ages[1] = 20;
            names[2] = "Gexam";
            ages[2] = 30;
            names[3] = "Simon";
            ages[3] = 40;
            names[4] = "Syuzi";
            ages[4] = 50;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
               yield return new Human() { Age = ages[i],Name = names[i]};
            }
        }
    }
}
