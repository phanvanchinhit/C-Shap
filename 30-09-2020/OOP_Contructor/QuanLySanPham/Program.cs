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
                        ghiFile(dsSanPham);
                        break;

                    case "2":
                            Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-20}",
                            "Ma san pham", "Ten san pham", "Mau sac",
                            "So luong", "Gia ban", "Tong tien");
                            //foreach (SanPham item in dsSanPham)
                            // {
                            //  Console.WriteLine(item.ToString());
                            //}
                            DocFile();
                        Console.ReadLine();
                        break;
                    case "3":
                        Program.deleteSp();
                        break;

                    case "4":
                        Program.editSanPham();
                        break;

                    case "5":
                        Program.searchSanPham();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
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
            Console.WriteLine("\n\nThem moi san pham thanh cong");
            Console.ReadLine();

        }
        static private void deleteSp()
        {
            string maspdel;
            int count = 0;
            Console.WriteLine("\nTim Kiem Thong Tin\n");
            Console.Write("\nNhap vao ma san pham can xoa: ");
            maspdel = Console.ReadLine();
            for (int i=0; i<dsSanPham.Count; i++)
            {
                if (maspdel == dsSanPham[i].MaSP)
                {
                    dsSanPham.Remove(dsSanPham[i]);
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("Khong tim thay san pham tren");
            }
            else
            {
                Console.WriteLine("\n\nXoa san pham thanh cong");
            }
            Console.ReadLine();
        }
        static private void searchSanPham()
        {
            string maspsearch;
            int count = 0;
            Console.WriteLine("\nTim Kiem Thong Tin\n");
            Console.Write("\nNhap vao ma san pham can search: ");
            maspsearch = Console.ReadLine();
            Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-20}",
                            "Ma san pham", "Ten san pham", "Mau sac",
                            "So luong", "Gia ban", "Tong tien");
            foreach (SanPham item in dsSanPham)
            {
                if(maspsearch == item.MaSP)
                {
                    Console.WriteLine(item.ToString());
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("\n\nKhong tim thay san pham tren");
            }
            Console.ReadLine();
        }
        static private void editSanPham()
        {
            string editsearch;
            int count = 0;
            Console.WriteLine("\nTim Kiem Thong Tin\n");
            Console.Write("\nNhap vao ma san pham can sua: ");
            editsearch = Console.ReadLine();
            for(int i=0; i<dsSanPham.Count; i++)
            {
                if (editsearch == dsSanPham[i].MaSP)
                {
                    string masp = dsSanPham[i].MaSP;
                    dsSanPham.Remove(dsSanPham[i]);
                    string tensp, mausac;
                    int soluong;
                    double giaban;
                    Console.Write("\nNhap vao ten san pham: ");
                    tensp = Console.ReadLine();
                    Console.Write("\nNhap vao mau sac san pham: ");
                    mausac = Console.ReadLine();
                    Console.Write("\nNhap vao so luong san pham: ");
                    soluong = int.Parse(Console.ReadLine());
                    Console.Write("\nNhap vao gia ban san pham: ");
                    giaban = double.Parse(Console.ReadLine());

                    SanPham update = new SanPham(masp, tensp, mausac, soluong, giaban);
                    dsSanPham.Add(update);
                    count++;
                }
                
            }
            if (count != 0)
            {
                Console.WriteLine("\nSua thanh cong");
            }
            else
            {
                Console.WriteLine("Khong tim thay san pham tren");
            }
            Console.ReadLine();
        }
        static private void ghiFile(List<SanPham> dsSanPham)
        {
            StreamWriter w = new StreamWriter("DanhSachSanPham.txt", true);
            foreach (SanPham item in dsSanPham)
            {
                w.WriteLine(item);
            }
            w.Close();
        }
        static private void DocFile()
        {
            StreamReader r = new StreamReader("DanhSachSanPham.txt");
            while( r.Peek() != -1)
            {
                Console.WriteLine(r.ReadLine());
            }
            r.Close();
            //Console.ReadLine();
        }
    }
}
