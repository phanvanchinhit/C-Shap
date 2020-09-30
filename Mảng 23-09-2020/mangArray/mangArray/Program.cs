using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = NhapMang(n);
            HienThiMang(mang);
            Console.WriteLine("\nGia tri trung binh cua cac phan tu mang: {0}", TinhGiaTriTrungBinh(mang));
            Console.ReadLine();
        }

        private static void HienThiMang(int [] mang)
        {
            Console.WriteLine("Mang da nhap /n");
            for(int i =0; i< mang.Length; i++)
            {
                Console.WriteLine("Phan tu {0} = {1}",i+1, mang[i]);
            }
        }
        private static int [] NhapMang(int n)
        {
            int[] mang = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("\nNhap vao so phan tu {0}:",i+1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            return mang;
        }
        static double TinhGiaTriTrungBinh(int [] mang)
        {
            int tong = 0;
            foreach(int item in mang)
            {
                tong += item;
            }
            return (double)tong / (double)mang.Length;
        }
    }
}
