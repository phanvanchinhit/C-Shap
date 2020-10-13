using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class SanPhamChatLuongCao:SanPham
    {
        private int _sanPCLC;

        public int SanPCLC
                {
                    get
                    {
                        return _sanPCLC;
                    }

                    set
                    {
                        _sanPCLC = value;
                    }
                }
        public SanPhamChatLuongCao() { }
        public SanPhamChatLuongCao(string ma, string ten, string mau, int soluong, double giaban ,int clc) :base(ma, ten, mau, soluong, giaban)
        {
            this.SanPCLC = clc;
        }

        public override double ThanhTien()
        {
            return this.SoLuong * this.GiaBan * this.SanPCLC;
        }
        public override string ToString()   
        {
            return string.Format("\n{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", this.MaSanPham, this.TenSanPham, this.MauSanPham, this.SoLuong, this.GiaBan , this.SanPCLC, this.ThanhTien());
        }
    }
}
