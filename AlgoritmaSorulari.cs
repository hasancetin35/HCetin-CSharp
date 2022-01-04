using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class AlgoritmaSorulari
    {

        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //   Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        public void ciftmi()
        {

            int n =  Convert.ToInt32( Console.ReadLine());

            int[] sayilar;
            sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int j = 0; j < n; j++)
            {

                if (sayilar[j]%2==0)
                {
                    Console.WriteLine(sayilar[j]);
                }

            }
            Console.ReadKey();

        }

        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
        //    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //    Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


        public void psayikontrol()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayilar;
            sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int j = 0; j < n; j++)
            {

                if (sayilar[j] % m == 0 || sayilar[j] ==m )
                {
                    Console.WriteLine(sayilar[j]);
                }

            }
            Console.ReadKey();



        }


        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //    Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //    Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        public void sonyaz()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string[] kelime;
            kelime = new string[n];
            for (int i = 0; i < n; i++)
            {
                kelime[i] = Console.ReadLine();

            }

            for (int j = 0; j < n; j++)
            {

                var sz = kelime[j].ToCharArray().Reverse();

                Console.WriteLine(new string(sz.ToArray()));

            }

        }


        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        //    Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        public void hksayisi()
        {

            string cmle = Console.ReadLine();

            string[] ckelime = cmle.Split(" ");

            

            Console.WriteLine(cmle.Count().ToString());

            Console.WriteLine(ckelime.Count());



        }


        public void test()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string[] kelime;
            kelime = new string[n];
            

            for (int i = 0; i < n; i++)
            {
                kelime[i] = Console.ReadLine();

            }


            for (int j = 0; j < n; j++)
            {
                string tk = "";
                string ck = "";

                for (int sy = 0; sy < kelime[j].Length; sy++)
                {


                    if (sy % 2 == 0 || sy==0)
                    {

                        ck = ck + kelime[j].Substring(sy, 1 );


                    }
                    else
                    {

                        tk = tk + kelime[j].Substring(sy, 1 );

                    }


                }

                Console.WriteLine(ck + " " + tk);

            }


        }

        public void strmetot()
        {


            string sdegisken = "Hasan ÇETİN";

            Console.WriteLine(sdegisken.ToUpper());
            Console.WriteLine(sdegisken.ToLower());

            Console.WriteLine(sdegisken.StartsWith("PAtika "));

            Console.WriteLine(sdegisken.IndexOf("Ha"));

            Console.WriteLine(sdegisken.Remove(4, 8));




        }


        public void dtmath()
        {

            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.AddHours(2));

            Console.WriteLine(DateTime.Now.ToString("HH"));


            Console.WriteLine(Math.Pow(2, 4));

            Console.WriteLine(Math.Abs(-23));
            Console.WriteLine(Math.Sqrt(9));






        }






    }





    }
}
