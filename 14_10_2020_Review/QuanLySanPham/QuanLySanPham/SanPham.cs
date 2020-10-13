using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class SanPham
    {
        private string _maSanPham;
        private string _tenSanPham;
        private string _mauSanPham;
        private int _soLuong;
        private double _giaBan;

        public string MaSanPham
        {
            get
            {
                return _maSanPham;
            }

            set
            {
                _maSanPham = value;
            }
        }

        public string TenSanPham
        {
            get
            {
                return _tenSanPham;
            }

            set
            {
                _tenSanPham = value;
            }
        }

        public string MauSanPham
        {
            get
            {
                return _mauSanPham;
            }

            set
            {
                _mauSanPham = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public double GiaBan
        {
            get
            {
                return _giaBan;
            }

            set
            {
                _giaBan = value;
            }
        }
        public SanPham() { }
        public SanPham(string ma, string ten, string mau, int soluong, double giaban)
        {
            this.MaSanPham = ma;
            this.TenSanPham = ten;
            this.MauSanPham = mau;
            this.SoLuong = soluong;
            this.GiaBan = giaban;
        }
        public virtual double ThanhTien()
        {
            return this.SoLuong * this.GiaBan;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", this.MaSanPham, this.TenSanPham, this.MauSanPham, this.SoLuong, this.GiaBan,0, this.ThanhTien());
        }
    }
}
