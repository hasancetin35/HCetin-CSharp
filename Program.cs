using System;

namespace HCetin_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Odevler nesne = new Odevler();

            // nesne.İlk();


            // nesne.Degiskenler();

            // nesne.Operatorler();

            //  nesne.tip_donusum();


            //  nesne.hatayakalama();

            //  nesne.ifelseif();

            // nesne.SwitchCase();

            nesne.whileornek();

            nesne.diziler();

            nesne.whileornek();

            nesne.Yazdir(5 , 6);
            nesne.Yazdir("Hasan", "Çetin");

            Console.WriteLine(nesne.fak(6));

            
        }
    }
}
