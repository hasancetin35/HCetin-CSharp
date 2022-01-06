using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class SinifOrnek
    {


        public string ad;

       public string soyad;

        public int yas;


        public SinifOrnek(string Ad, string Soyad, int Yas)
        {

            ad = Ad;
            soyad = Soyad;
            yas = Yas;


        }

        public SinifOrnek()
        {


        }


        public void bilgigoster()
        {

            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);


        }
    }
}
