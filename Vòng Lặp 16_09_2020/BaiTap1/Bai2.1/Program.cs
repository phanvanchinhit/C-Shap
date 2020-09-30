using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("So {0} la so chan", n);
            }
            else
            {
                Console.WriteLine("So {0} la so le", n);
            }
            Console.ReadLine();
        }
    }
}
