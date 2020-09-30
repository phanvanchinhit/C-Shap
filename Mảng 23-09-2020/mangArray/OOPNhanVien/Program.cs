using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien chinh = new NhanVien();
            NhanVien em = new NhanVien();
            

            chinh.MaNhanVien = "001";
            chinh.TenNhanVien = "Phan Van Chinh";
            chinh.Luong1Gio = 200;
            chinh.SoGioLamViec = 2000;

            Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}", chinh.MaNhanVien, chinh.TenNhanVien, chinh.Luong1Gio, chinh.SoGioLamViec, chinh.LuongNhanVien());

            em.Nhap("002", "Nguyen Vy Yen", 150, 3000);
            Console.WriteLine(em.Xuat());
          
            Console.WriteLine("Nhap thong tin nhan vien 3");
            Console.Write("Nhap vao so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] nv3 = new NhanVien[n];
            for (int i=1; i<=n; i++)
            {
                Console.Write("Nhap thong tin nhan vien {0} la\n", i);
                nv3[i] = new NhanVien();
                Console.Write("Nhap ma nhan vien: ");
                nv3[i].MaNhanVien = Console.ReadLine();
                Console.Write("\nNhap ten nhan vien: ");
                nv3[i].TenNhanVien = Console.ReadLine();
                Console.Write("\nNhap so luong 1 gio nhan vien: ");
                nv3[i].Luong1Gio = int.Parse(Console.ReadLine());
                Console.Write("\nNhap so gio lam viec: ");
                nv3[i].SoGioLamViec = int.Parse(Console.ReadLine());

            }
            for(int i=1; i<=n; i++)
            {
                nv3[i].Xuat();
            }



            Console.ReadLine();
        }
    }
}
