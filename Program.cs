using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_15
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Rekürsif
            int a = UsAlma.Expo(3, 3);
            Console.WriteLine("Rekürsif fonksiyonun cevabı: {0}",a);

            //Extension: Static tanımlanmalı
            string deneme = "Ömer Gökdaş";
            Console.WriteLine("Boşluklari ayikladım: {0}",deneme.BosluklariAyir());
            Console.ReadLine();
        }
    }

    public class UsAlma
    {
        public static int Expo(int sayi1, int us)
        {
            if (us < 2)
            {
                return sayi1;
            }

            else if(us==0){
                return 1;
            }
            else
            {
                return Expo(sayi1, us-1) * sayi1;
            }
        }
    }

    public static class extensions {

        public static bool BoslukVarmi(this string abc)
        {
            return abc.Contains(" ");
        }

        public static string BosluklariAyir(this string xyz)
        {
            if (BoslukVarmi(xyz) == true)
            {
                string[] dizi = xyz.Split();
                return string.Join("", dizi);
            }
            else
            {
                return xyz;
            }
        }
    }

}
