using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCetin_CSharp
{
    public static class Exmetot
    {


        public static bool Tekmi( this int param)
        {

            if (param % 2 == 0)
            {
                return true;

            }
            else
                return false;


        }

        static readonly int deger = 5;
        static readonly bool durum = deger.Tekmi();

        


    }
}
