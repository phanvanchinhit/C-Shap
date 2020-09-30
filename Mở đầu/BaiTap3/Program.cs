using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Nhap vao so x: ");
            x =int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTong cua 2 so x + y la: {0}", x + y);
            Console.WriteLine("\nHieu cua 2 so x - y la: {0}", x - y);
            Console.WriteLine("\nNhan cua 2 so x * y la: {0}", x * y);
            Console.WriteLine("\nChia cua 2 so x / y la: {0}", x / y);
            Console.WriteLine("\nChia Lay du cua 2 so x % y la: {0}", x % y);
            double h = (double)x / y;
            Console.WriteLine("\nChia cua 2 so x / y la: {0}", h);

            Console.ReadLine();

        }
    }
}
