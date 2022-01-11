using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class Odevler
    {
        public void İlk()
        {

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
                Console.WriteLine("şart doğru");

            }

            if (isSucces || iscompleted)
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
            object obj = e + f + g;

            Console.Write(obj);


        }


        public void hatayakalama()
        {

            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

        }

        public void ifelseif()
        {

            int time = DateTime.Now.Hour;
            Console.WriteLine(time);


            if (time >= 6 && time <= 12)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {

                Console.WriteLine("Tünaydın");

            }

            else
                Console.WriteLine("İyi geceler");

            string sonuc = time <= 12 ? "Günaydın" : time <= 18 ? "Tünaydın" : " iyi geceler";
        }

        public void SwitchCase()
        {

            int month = DateTime.Now.Month;



            switch (month)
            {

                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;

                case 12:
                    Console.WriteLine("Aralık");
                    break;



                default:
                    Console.WriteLine("Yanlış veri girildi");
                    break;
            }

            switch (month)
            {

                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Kış Mevsimi");
                    break;

                default:
                    break;
            }




        }

        public void whileornek()
        {

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {


                toplam = toplam + sayac;


                sayac++;
            }
            Console.WriteLine(toplam);

            string[] arabalar = { "bmv", "mercedes", "nissan", "opel" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }

        public void diziler()
        {

            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş", "at" };



            int[] dizi;

            dizi = new int[5];


            renkler[0] = "mavi";

            Console.WriteLine(hayvanlar[1]);

            int[] diziuzunluk = new int[5];

            foreach (var diz in diziuzunluk)
            {

                Console.WriteLine(diz);
            }





        }

        public void Arrayornek()
        {
            int[] sayidizisi = { 6, 7, 3, 9, 6, 2, 7, 12, 6, 8, 8 };




            foreach (var say in sayidizisi)
            {
                Console.WriteLine(say);
            }


            Array.Sort(sayidizisi);
            foreach (var say in sayidizisi)
            {
                Console.WriteLine(say);
            }
            Array.Clear(sayidizisi, 2, 2);

            Array.Reverse(sayidizisi);

            Array.IndexOf(sayidizisi, 7);



        }

        public string Yazdir(string a, string b)
        {

            return a + b;


        }

        public int Yazdir(int a, int b)
        {
            return a + b;


        }


        public int fak(int n)

        {

            if (1 <= n)
            {
                return 1;
            }

            return n * fak(n - 1);

        }











    }
}
