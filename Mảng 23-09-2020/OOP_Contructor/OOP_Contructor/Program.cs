using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien NhanVien1 = new NhanVien();
            NhanVien nv3 = new NhanVien();
            List<NhanVien> nv4 = new List<NhanVien>();
            NhanVien1.MaNhanVien = "NV01";
            NhanVien1.TenNhanVien = "Nguyen Van A";
            NhanVien1.Luong1Gio = 2;
            NhanVien1.SoGioLam = 10;
            for(int i=1; i<3; i++)
            {
                Console.Write("\nNhap ma nhan vien: ");
                nv4[i].MaNhanVien = Console.ReadLine();
                Console.Write("\nNhap ten nhan vien: ");
                nv4[i].TenNhanVien = Console.ReadLine();
                Console.Write("\nNhan Vao so luong 1 gio: ");
                nv3.Luong1Gio = int.Parse(Console.ReadLine());
                Console.Write("\nNhap so gio lam: ");
                nv3.SoGioLam = int.Parse(Console.ReadLine());
            }
            NhanVien nhanVien2 = new NhanVien("NV02", "Nguyen Van B", 3, 20);

            Console.Write("\nNhap ma nhan vien: ");
            nv3.MaNhanVien = Console.ReadLine();
            Console.Write("\nNhap ten nhan vien: ");
            nv3.TenNhanVien = Console.ReadLine();
            Console.Write("\nNhan Vao so luong 1 gio: ");
            nv3.Luong1Gio = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so gio lam: ");
            nv3.SoGioLam = int.Parse(Console.ReadLine());
            Console.WriteLine(nv3.ToString());

            Console.WriteLine(NhanVien1.ToString());
            Console.WriteLine(nhanVien2.ToString());
            Console.ReadLine();
        }
    }
}
