using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính chu vi và dien tich hinh vuong
            float a, c = 0, s = 0;
            Console.Write("Nhap vao chieu dai hinh vuong la: ");
            a = float.Parse(Console.ReadLine());
            c =  4*a;
            s = (float)a * a;
            Console.WriteLine("Chu vi hinh vuong la: {0} m", c);
            Console.WriteLine("Dien tich hinh vuong la: {0} m2", s);
            Console.ReadLine();
        }
    }
}
