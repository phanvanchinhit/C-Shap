using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính chu vi và dien tich hinh chu nhat
            float a, b,c=0,s=0;
            Console.Write("Nhap vao chieu dai hcn la: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu rong hcn la: ");
            b = float.Parse(Console.ReadLine());
            c = (a + b) * 2;
            s = (float)a * b;
            Console.WriteLine("Chu vi hinh chu nhat la: {0} m", c);
            Console.WriteLine("Dien tich hinh chu nhat la: {0} m2", s);
            Console.ReadLine();
        }
    }
}
