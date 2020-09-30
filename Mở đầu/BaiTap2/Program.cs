using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, x;
            Console.Write("\nNhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nNhap he so b: ");
            b = double.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine("\nPhuong trinh {0}x + {1} = 0 co nghiem x = {2}"
        , a, b, x);
            Console.ReadLine();

        }
    }
}
