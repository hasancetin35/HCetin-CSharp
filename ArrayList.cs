using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class ArrayListesinif
    {
        public void arraylist()
        {


            ArrayList liste = new ArrayList();

            liste.Add("hasan");


            liste.Add(4);


            Console.WriteLine(liste[1]);


            foreach (var item in liste)
            {

                Console.WriteLine(item);

            }


            List<int> sayilar = new List<int>()
            {
                3,5,7,8,9,9,
            };


            liste.AddRange(sayilar);



            liste.Sort();

            foreach(var item in liste)
            {

                Console.WriteLine(item);


            }


            Console.Write(liste.BinarySearch(8));


            liste.Reverse();
            
        }



    }
}
