using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            double d, x1, x2;
            Console.Write("-----------+++++++-------------");
            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai\n");
            Console.Write("-----------+++++++-------------");
            Console.Write("\n\n");
            try
            {
                Console.Write("Nhap gia tri cua a: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("\nNhap gia tri cua b: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("\nNhap gia tri cua c: ");
                c = float.Parse(Console.ReadLine());
                Console.Write("\n");
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Phuong trinh co vo so nghiem");
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh vo nghiem");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co 1 nghiem duy nhat: {0}", (float)-c / b);
                    }
                }
                else
                {
                    d = b * b - 4 * a * c;
                    if (d == 0)
                    {
                        Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                        x1 = -b / (2.0 * a);
                        x2 = x1;
                        Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1);
                    }
                    else if (d > 0)
                    {
                        Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);

                        Console.Write("Nghiem thu nhat: x1 = {0}\n", x1);
                        Console.Write("Nghiem thu nhat: x2 = {0}\n", x2);
                    }
                    else
                        Console.Write("Phuong trinh vo nghiem\n\n");
                }
            }
            catch
            {
                Console.WriteLine("Nhap loi!!!\nXin Vui Long Thu Lai");
            }

            Console.ReadLine();
        }
    }
}
