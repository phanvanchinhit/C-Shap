using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanPham
{
    class SanPham
    {
        private string _masp;
        private string _tensp;
        private string _mausp;
        private int _soluong;
        private double _giaban;

        public string maSP
        {
            get
            {
                return _masp;
            }
            set
            {
                _masp = value;
            }
        }
        public string tenSP
        {
            get
            {
                return _tensp;
            }
            set
            {
                _tensp = value;
            }
        }
        public string mauSP
        {
            get
            {
                return _mausp;
            }
            set
            {
                _mausp = value;
            }
        }
        public int soLuong
        {
            get
            {
                return _soluong;
            }
            set
            {
                _soluong = value;
            }
        }
        public double giaBan
        {
            get
            {
                return _giaban;
            }
            set
            {
                _giaban = value;
            }
        }
        public SanPham() { }

        public SanPham(string ma, string ten, string mau, int soluong, double giaban)
        {
            this.maSP = ma;
            this.tenSP = ten;
            this.mauSP = mau;
            this.soLuong = soluong;
            this.giaBan = giaban;
        }
        public double TinhTien()
        {
            return this.giaBan * this.soLuong;
        }
        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-20}{4,-15}{5,-20}",this.maSP, this.tenSP, this.mauSP, this.soLuong, this.giaBan, this.TinhTien());
        }

    }
}
