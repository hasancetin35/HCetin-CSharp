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







    }
}
