using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPerson
{
    class Program
    {
        static public List<CONGNHAN> dsCongNhan = new List<CONGNHAN>();
        static void Main(string[] args)
        {
            int n;
            Console.Write("\nNhap vao so luong cong nhan: ");
            n = int.Parse(Console.ReadLine());
            for( int i=1; i<=n; i++)
            {
                string hoten, gioitinh, diachi, tencongty, ngaylamviec;
                int namsinh;
                double hesoluong;
                Console.WriteLine("\nNhập vào thông tin công nhân thứ {0}\n", i);
                Console.Write("\nNhap vao ho ten cong nhan: ");
                hoten = Console.ReadLine();
                Console.Write("\nNhap vao gioi tinh cong nhan: ");
                gioitinh = Console.ReadLine();
                Console.Write("\nNhap vao nam sinh cong nhan: ");
                namsinh = int.Parse(Console.ReadLine());
                Console.Write("\nNhap vao dia chi cong nhan: ");
                diachi = Console.ReadLine();
                Console.Write("\nNhap vao ten cong ty: ");
                tencongty = Console.ReadLine();
                Console.Write("\nNhap vao ngay bat dau lam viec: ");
                ngaylamviec = Console.ReadLine();
                Console.Write("\nNhap vao he so luong: ");
                hesoluong = double.Parse(Console.ReadLine());

                CONGNHAN congnhanmoi = new CONGNHAN(hoten, gioitinh, namsinh, diachi, tencongty, ngaylamviec, hesoluong);
                dsCongNhan.Add(congnhanmoi);
            }

            Console.WriteLine("\n{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", "Ho Ten", "Gioi Tinh", "Nam Sinh", "Dia Chi", "Ten Cong Ty", "Ngay Lam Viec", "He So Luong");

            foreach(CONGNHAN item in dsCongNhan)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nSap xep theo he so luong giam dan\n");
            for(int i=0; i< dsCongNhan.Count; i++)
            {
                for( int j=i+1; j<dsCongNhan.Count; j++)
                {
                    if(dsCongNhan[i].HeSoLuong < dsCongNhan[j].HeSoLuong)
                    {
                        CONGNHAN tmp = dsCongNhan[i];
                        dsCongNhan[i] = dsCongNhan[j];
                        dsCongNhan[j] = tmp;

                    }
                }
            }
            Console.WriteLine("\n{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", "Ho Ten", "Gioi Tinh", "Nam Sinh", "Dia Chi", "Ten Cong Ty", "Ngay Lam Viec", "He So Luong");

            foreach (CONGNHAN item in dsCongNhan)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
