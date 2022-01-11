using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public class Koleksiyon1
    {

        public void odev1()
        {
        
            ArrayList asalsayilar = new ArrayList();
            ArrayList digersayilar = new ArrayList();

            int sayi = 0;

            do
            {
                try
                {
                    int gsayi = Convert.ToInt32(Console.ReadLine());

                    if (gsayi > 0)
                    {
                        int durum = 0;

                        for (int kontrol = 2; kontrol < gsayi; kontrol++)
                        {
                            if (gsayi%kontrol == 0)
                            {
                                durum++;
                            }
                        }
                        if (durum != 0 )
                        {
                           digersayilar.Add(gsayi);
                        }
                        else
                        {
                             asalsayilar.Add(gsayi);
                            
                        }
                        sayi++;
                }
                }
                catch (Exception)
                {
                }

            } while (sayi < 20);

            asalsayilar.Sort();
            asalsayilar.Reverse();
            digersayilar.Sort();
            digersayilar.Reverse();

            int asayitopla = 0;
            int bsayitopla = 0;

            foreach (int asayi in asalsayilar)
            {
                Console.WriteLine(asayi);
                asayitopla = asayitopla + asayi;
            }
            Console.WriteLine("Asal sayı sayısı" + asalsayilar.Count + " ortalaması " + asayitopla / asalsayilar.Count);

            foreach (int dsayi in digersayilar)
            {
                Console.WriteLine(dsayi);
                bsayitopla = bsayitopla + dsayi;
            }
            Console.WriteLine("Diger sayı sayısı " + digersayilar.Count + " ortalama" + bsayitopla / digersayilar.Count);

        }

        //  
        public void odev2()
        {
            ArrayList fsayi = new ArrayList();
            ArrayList bsayi = new ArrayList();
            ArrayList ksayi = new ArrayList();

            int sayi = 0;

            do
            {
                try
                {
                    int gsayi = Convert.ToInt32(Console.ReadLine());

                    if (gsayi > 0)
                    {



                        fsayi.Add(gsayi);


                        sayi++;
                    }
                }
                catch (Exception)
                {
                }

            } while (sayi < 20);

            fsayi.Sort();

            int bortalama = 0;
            int kortalama = 0;
            for (int i = 0; i < 3; i++)
            {
               Console.WriteLine( fsayi[i]);
                kortalama = kortalama + Convert.ToInt32(fsayi[i]);
            }
            Console.WriteLine(" Toplamı = " + kortalama + "ortalaması " + kortalama / 3);
            fsayi.Reverse();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(fsayi[i]);
                bortalama = bortalama + Convert.ToInt32(fsayi[i]);

            }
            Console.WriteLine("Toplamı " + bortalama + "ortalaması" + bortalama / 3);



            //







        }






    }
}
