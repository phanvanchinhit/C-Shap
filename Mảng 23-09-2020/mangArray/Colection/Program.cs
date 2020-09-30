using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Colection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dsSoNguyen = new ArrayList();
            NhapDanhSachSoNguyen(dsSoNguyen);
            HienThiDanhSach(dsSoNguyen);
            Console.WriteLine("\nPhan tu max {0}", TimPhanTuLonNhat(dsSoNguyen));

            Console.ReadLine();
     
        }
       private static void HienThiDanhSach(ArrayList dsSoNguyen)
        {
            Console.WriteLine("\nCac So da nhap: \n");
            foreach( var item in dsSoNguyen)
            {
                Console.Write("\t{0}", item);
            }
        }
        private static void NhapDanhSachSoNguyen(ArrayList dsSoNguyen)
        {
            string tiepTuc = "";
            while(tiepTuc != "n")
            {
                Console.Write("Nhap vao 1 so: ");
                dsSoNguyen.Add(Console.ReadLine());
                Console.Write("\nNhan n de ket thuc\n");
                tiepTuc = Console.ReadLine().ToLower();
            }
        }
        static double TimPhanTuLonNhat(ArrayList ds)
        {
            double max = Convert.ToDouble(ds[0]);
            for(int i=1; i < ds.Count; i++)
            {
                if(max < Convert.ToDouble(ds[i]))
                {
                    max = Convert.ToDouble(ds[i]);
                }
            }
            return max;
        }
    }
}
