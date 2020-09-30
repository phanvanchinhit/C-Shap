using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien();
            Console.WriteLine("Nhap thong tin nhan vien 1");
            Console.Write("\nNhap vao ma nhan vien: ");
            nv1.maNhanVien = Console.ReadLine();
            Console.Write("\nNhap vao ten nhan vien: ");
            nv1.tenNhanVien = Console.ReadLine();
            Console.Write("\nNhap vao luong 1 gio: ");
            nv1.luong1Gio = int.Parse(Console.ReadLine());
            Console.Write("\nNhap vao so gio lam: ");
            nv1.soGioLam = int.Parse(Console.ReadLine());
            Console.WriteLine(nv1.ToString());

            NhanVien nv2 = new NhanVien("nv2","l ")

            Console.ReadLine();
        }
    }
}
