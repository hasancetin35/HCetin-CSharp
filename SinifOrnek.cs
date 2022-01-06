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

    class Calisan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }
   

        private string isim;

        private string soyisim;


        public Calisan(string Isim,string Soyisim)
        {

            isim = Isim;
            soyisim = Soyisim;
            calisanSayisi++;

        }

        static Calisan()
        {
            calisanSayisi = 0;
        }
    }



    struct Dikdorgen_Struct

    {
        public int kisakenar;

        public int uzunkenar;


        public long Alanhesapla()
        {

            return this.kisakenar * this.uzunkenar;


        }


    }


}
