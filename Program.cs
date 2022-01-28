using System;

namespace ArraySinifi_Metodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi = { 23, 56, 86, 35, 1, 13, 7, 5 };
            Console.WriteLine("***** Sırasız Dizi");

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.WriteLine("***** Sıralı Dizi");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.WriteLine("***** Array Clear");
            Array.Clear(sayiDizisi, 2, 3);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.WriteLine("***** Array Reverse");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);



            Console.WriteLine("***** Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 56));



            Console.WriteLine("***** Array Resize");
            Array.Resize<int>(ref sayiDizisi, 12);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
