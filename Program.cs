using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableTipaDouble_IvaSosic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- 1. zadatak ----");
            double a=1.5, b=2, c=3.5, d=4, x;
            x = ((a * a + b * b + c * c + d * d) % (Math.Pow((a + b), 2) + Math.Pow((c+d),2)));
            Console.WriteLine("Vrijednost x-a je: " + x);

            Console.WriteLine("\n---- 2. zadatak ----");
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8) + s2.Substring(7, 17);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("\n -- Novi s3 --");
            Console.WriteLine(s3);

            Console.WriteLine("\n---- 3. zadatak ----");
            Console.WriteLine("Unesite neku rečenicu: ");
            string rijec = Console.ReadLine();
            string[] Srijec = rijec.Split(' ');
            Console.WriteLine("Prva rijec: {0}", Srijec[0]);
            Console.WriteLine("Zadnja rijec: {0}", Srijec[Srijec.Length - 1]);

            Console.WriteLine("\n 5. zadatak: ");
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene s razmakom");
            string s5 = Console.ReadLine();
            string[] s6 = s5.Split(' ');
            string x2 = s6[0];
            string y = s6[1];
            Console.WriteLine("Vrijednost x= " + x2 + "\nVrijednost y= " + y);
            Console.WriteLine();




            Console.ReadKey();
        }
    } 
}
