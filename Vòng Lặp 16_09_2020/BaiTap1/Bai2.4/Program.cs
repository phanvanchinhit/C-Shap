using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ten;
                float toan, ly, hoa;
                Console.Write("Nhap ten cua hoc sinh: ");
                ten = Console.ReadLine();
                Console.WriteLine("Nhap diem cua hoc sinh");
                Console.Write("\nDiem Toan: ");
                toan = float.Parse(Console.ReadLine());
                Console.Write("\nDiem Ly: ");
                ly = float.Parse(Console.ReadLine());
                Console.Write("\nDiem Hoa: ");
                hoa = float.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin hoc sinh");
                Console.WriteLine(string.ToUpper(ten));
                Console.WriteLine("Ho va Ten: {0}", ten);
                Console.WriteLine("Diem Toan: {0}", toan);
                Console.WriteLine("Diem Ly: {0}", ly);
                Console.WriteLine("Diem Hoa: {0}", hoa);
            }
            catch
            {
                Console.WriteLine("Nhap loi");
            }
            Console.ReadLine();
        }
    }
}
