using System;
using System.Collections.Generic;

namespace HCetin_CSharp
{
    public class GenericList
    {


        public void glist()
        {


            List<int> sayilistesi = new List<int>;


            sayilistesi.Add(4);
            sayilistesi.Add(9);



            foreach (var sl in sayilistesi)
            {
                Console.WriteLine(sl);
            }


            sayilistesi.ForEach(say => Console.WriteLine(say));

            sayilistesi.Remove(4);

            sayilistesi.RemoveAt(0);

            sayilistesi.ForEach(say => Console.WriteLine(say));


            if(sayilistesi.Contains(9))
            {


                Console.Write("Bulundu");
            }


            sayilistesi.BinarySearch(9);


            string[] hayvanlar = { "kedi", "kopek", "kuş" };

            List<string> hayvanlarlistesi = new List<string>(hayvanlar);



            List<kullanici> kullanicilistesi = new List<kullanici>();

            kullanici kullanicinesne = new kullanici();

            kullanicinesne.Isim = "hasan";

            kullanicinesne.Soyisim = "çetin";

            kullanicinesne.Yas = 33;

            kullanici kullanicinesne2 = new kullanici();

            kullanicinesne2.Isim = "hasan";

            kullanicinesne2.Soyisim = "çetin";

            kullanicinesne2.Yas = 33;



            kullanicilistesi.Add(kullanicinesne);
            kullanicilistesi.Add(kullanicinesne2);












        }



    }

    public class kullanici
    {
        private string isim;

      

        private string soyisim;


        private int yas;

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
