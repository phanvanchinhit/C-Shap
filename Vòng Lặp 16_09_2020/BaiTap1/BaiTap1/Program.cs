using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiTap1
{
    class Program
    {
        private static string chuyen(double diem)
        {
            
            if (diem < 4)
            {
                return "F";
            }
            else if (diem >= 4 && diem < 5.5)
            {
                return "D";
            }
            else
                return "A";
        }
        static void Main(string[] args)
        {
            double diem;
            Console.Write("Nhap vao diem cua ban: ");
            diem = double.Parse(Console.ReadLine());
            string diemChu = chuyen(diem);
            Console.WriteLine("Diem chu cua ban la: {0}", diemChu);
            
        Console.ReadLine();
        
    }

    
    }
}
