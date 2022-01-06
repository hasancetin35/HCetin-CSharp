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


        private string meslek;

        private int boy;

        public string Meslek { get => meslek; set => meslek = value; }
        public int Boy { get => boy; set => boy = value; }

        public SinifOrnek(string Ad, string Soyad, int Yas, string meslek)
        {

            ad = Ad;
            soyad = Soyad;
            yas = Yas;
            Meslek = meslek;
        }

        public SinifOrnek()
        {


        }


        public void bilgigoster()
        {

            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);
            Console.WriteLine(Meslek);


        }
    }
}
