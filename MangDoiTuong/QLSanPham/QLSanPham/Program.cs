using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanPham
{
    class Program
    {
        private static List<SanPham> dsSanPham = new List<SanPham>();
        static void Main(string[] args)
        {
            int n;
            Console.Write("\nNhap so luong san pham: ");
            n = int.Parse(Console.ReadLine());
            for(int i= 0; i<n; i++)
            {
                string masp, tensp, mausac;
                int soluong;
                double giaban;
                Console.WriteLine("Nhap thong tin san pham thu: {0}", i+1,"\n");
                Console.Write("\nNhap vao ma san pham: ");
                masp = Console.ReadLine();
                Console.Write("\nNhap vao ten san pham: ");
                tensp = Console.ReadLine();
                Console.Write("\nNhap vao mau sac san pham: ");
                mausac = Console.ReadLine();
                Console.Write("\nNhap vao so luong san pham: ");
                soluong = int.Parse(Console.ReadLine());
                Console.Write("\nNhap vao gia ban san pham: ");
                giaban = double.Parse(Console.ReadLine());

                SanPham sanphammoi = new SanPham(masp, tensp, mausac, soluong, giaban);
                dsSanPham.Add(sanphammoi);
            }
            Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-20}{4,-15}{5,-20}", "Ma san pham", "Ten san pham", "Mau sac",
                            "So luong", "Gia ban", "Tong tien");
            foreach (SanPham item in dsSanPham)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
