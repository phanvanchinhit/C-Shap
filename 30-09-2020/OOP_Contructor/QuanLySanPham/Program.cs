using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class Program
    {
        private static List<SanPham> dsSanPham = new List<SanPham>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nMAIN MENU:");
                Console.WriteLine("\n1. Nhap vao san pham moi");
                Console.WriteLine("\n2. Hien thi danh sach");
                Console.WriteLine("\n3. Xoa san pham theo ma san pham");
                Console.WriteLine("\n4. Sua san pham theo ma san pham");
                Console.WriteLine("\n5. Tim kiem san pham theo ma san pham");
                Console.WriteLine("\n6. Thoat");
                Console.Write("\nNhap vao lua chon cua ban:");
                string bien = Console.ReadLine();
                switch (bien)
                {
                    case "1":
                        Program.addSanPham();
                        break;

                    case "2":
                        Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-20}",
                            "Ma san pham", "Ten san pham", "Mau sac",
                            "So luong", "Gia ban", "Tong tien");
                        foreach(SanPham item in dsSanPham)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.ReadLine();
                        break;

                    case "5":
                        Program.searchSanPham();
                        break;
                }
            } while (true);
        }
        static private void editSanPham()
        {

        }
        static private void addSanPham()
        {
            string masp, tensp, mausac;
            int soluong;
            double giaban;
            Console.WriteLine("Nhap thong tin san pham");
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
        static private void deleteSp()
        {
            string maspdel;
            Console.WriteLine("\nTim Kiem Thong Tin\n");
            Console.Write("\nNhap vao ma san pham can search: ");
            maspdel = Console.ReadLine();
            foreach (SanPham item in dsSanPham)
            {
                if (maspdel == item.MaSP)
                {
                    dsSanPham.Remove(item);
                }
                else
                {
                    Console.WriteLine("Khong tim thay san pham tren");
                }
            }
            Console.ReadLine();
        }
        static private void searchSanPham()
        {
            string maspsearch;
            Console.WriteLine("\nTim Kiem Thong Tin\n");
            Console.Write("\nNhap vao ma san pham can search: ");
            maspsearch = Console.ReadLine();
            foreach(SanPham item in dsSanPham)
            {
                if(maspsearch == item.MaSP)
                {
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    Console.WriteLine("Khong tim thay san pham tren");
                }
            }
            Console.ReadLine();
        }
    }
}
