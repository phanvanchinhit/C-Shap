using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            float s = 0;
            for(int i=1; i<=n; i++)
            {
                s = s + giaiThua(i);
            }
            Console.Write("\nTong S = {0}", s);
            Console.ReadLine();
        }
        private static int giaiThua(int n){
            int gt = 1;
            for(int i = 1; i<=n; i++){
                gt = gt* i;
             }
                return gt;
            }
    }
}
