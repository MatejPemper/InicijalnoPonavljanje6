using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            Console.WriteLine("Unesi broj članova reda za sumu: ");
            int brClanova = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(" + 1/" + Math.Pow(3, i));
                i++;
            }
            while (i <= brClanova);



                Console.ReadKey();
        }
    }
}
