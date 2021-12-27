using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class Odevler
    {
        public void İlk() {

            Console.WriteLine("Merhaba adınızı giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınız");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Merhabalar " + isim + " " + soyisim);




        
        
        }




        public void Degiskenler()
        {
            int degisken = 5;
            string deger = null;

            byte b = 5;

            sbyte c = 6;

            short s = 5;


            Int32 say = 12;

            float fsay = 34;

            char ch = 'h';

            bool bl = true;

            DateTime dt = DateTime.Now;

            object o1 = "h";
            object o2 = 6;


            Console.WriteLine(deger + dt.ToString());


            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }



    }
}
