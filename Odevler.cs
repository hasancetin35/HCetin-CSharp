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

        public void Operatorler()
        {

            int x = 5;
            int y = 5;
            y = y + 3;
            Console.WriteLine(y);
            y += 3;
            y /= 1;
            Console.WriteLine(y);

            // Mantıksal Operatörler

            bool isSucces = true;
            bool iscompleted = false;

            if (isSucces && iscompleted)
            {
                Console.WriteLine("şart doğru");s

            }

            if (isSucces  || iscompleted)
            {
                Console.WriteLine("Harika"); 

            }


            int h = 3;
            int k = 4;
            bool sonuc = h < k;
            Console.WriteLine(sonuc);

            int sayi1 = 5;
            int sayi2 = 7;
            int sonucc = sayi1 + sayi1;

            Console.WriteLine(sonucc);


            int sonucm = 20 % 3;
            Console.WriteLine(sonucm);

        }

        public void tip_donusum()
        {


            byte a = 4;
            byte b = 3;


            int c = a + b;

            Console.WriteLine(c);



            string e = "merhaba";
            string f = " dünya";

            char g = '2';
            object obj = e + f+ g;

            Console.Write(obj);


        }



    }
}
