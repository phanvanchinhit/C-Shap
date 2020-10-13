using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLySanPham
{
    class Program
    {
        public static List<SanPham> dsSanPham = new List<SanPham>();
        static void Main(string[] args)
        {
            NhapSanPham();
            NhapSPCLC();
            GhiFile(dsSanPham);
            Console.WriteLine("Doc ra san pham: ");
            DocFile();
            Console.WriteLine("XUat ra nhe:");
            Xuat();
            Console.ReadLine();
            
        }

        static public void NhapSanPham()
        {
            string ma, ten, mau;
            int soluong; 
            double giaban;
            Console.WriteLine("Nhap san Pham mơi\n");
            Console.Write("Nhap vao ma san pham: ");
            ma = Console.ReadLine();
            Console.Write("Nhap vao ten san pham: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap vao mau san pham: ");
            mau = Console.ReadLine();
            Console.WriteLine("Nhap vao so lương: ");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia ban san pham: ");
            giaban = double.Parse(Console.ReadLine());
            SanPham sanphammoi = new SanPham(ma, ten, mau, soluong, giaban);
            dsSanPham.Add(sanphammoi);
        }
        static public void NhapSPCLC()
        {
            string ma, ten, mau;
            int soluong, clc;
            double giaban;
            Console.WriteLine("Nhap san Pham mơi\n");
            Console.Write("Nhap vao ma san pham: ");
            ma = Console.ReadLine();
            Console.Write("Nhap vao ten san pham: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap vao mau san pham: ");
            mau = Console.ReadLine();
            Console.WriteLine("Nhap vao he so CLC: ");
            clc = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so lương: ");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia ban san pham: ");
            giaban = double.Parse(Console.ReadLine());
            SanPhamChatLuongCao spclc = new SanPhamChatLuongCao(ma, ten, mau, soluong, giaban, clc);
            dsSanPham.Add(spclc);
        }
        static public void Xuat()
        {
            foreach(SanPham item in dsSanPham)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static public void GhiFile(List<SanPham> dsSanPham)
        {
            StreamWriter w = new StreamWriter(@"D:\C-Shap\14_10_2020_Review\DanhSachSanPham.txt", true);
            foreach (SanPham item in dsSanPham)
            {
                w.WriteLine(item);
            }
            w.Close();
        }
        static public void DocFile()
        {
            StreamReader r = new StreamReader(@"D:\C-Shap\14_10_2020_Review\DanhSachSanPham.txt");
            while(r.Peek() != -1)
            {
                Console.WriteLine(r.ReadLine());
            }
            r.Close();
        }

    }
}
