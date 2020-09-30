using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class SanPham
    {
        private string _MaSP;
        private string _TenSp;
        private string _MauSac;
        private int _SoLuong;
        private double _GiaBan;

        public string MaSP
        {
            get
            {
                return _MaSP;
            }
            set
            {
                _MaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return _TenSp;
            }
            set
            {
                _TenSp = value;
            }
        }
        public string MauSac
        {
            get
            {
                return _MauSac;
            }
            set
            {
                _MauSac = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                _SoLuong = value;
            }
        }
        public double GiaBan
        {
            get
            {
                return _GiaBan;
            }
            set
            {
                _GiaBan = value;
            }
        }

        public SanPham() { }
        public SanPham(string ma, string ten, string mau, int soluong, double giaban)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.MauSac = mau;
            this.SoLuong = soluong;
            this.GiaBan = giaban;
        }
        public double TinhTien()
        {
            return this.GiaBan * this.SoLuong;
        }
        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-15}{4,-15}{5,-20}", this.MaSP, this.TenSP, this.MauSac, this.SoLuong, this.GiaBan, this.TinhTien());
        }
    }
}
