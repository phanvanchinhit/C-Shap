using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNhanVien
{
    class NhanVien
    {
        private string _MaNhanVien;
        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }
            set
            {
                _MaNhanVien = value;
            }
        }
        private string _TenNhanVien;
        public string TenNhanVien
        {
            get
            {
                return _TenNhanVien;
            }
            set
            {
                _TenNhanVien = value;
            }
        }
        private int _Luong1Gio;
        public int Luong1Gio
        {
            get
            {
                return _Luong1Gio;
            }
            set
            {
                _Luong1Gio = value;
            }
        }
        private int _SoGioLamViec;
        public int SoGioLamViec
        {
            get
            {
                return _SoGioLamViec;
            }
            set
            {
                _SoGioLamViec = value;
            }
        }
        public void Nhap( string ma, string ten, int luong1gio, int sogio)
        {
            this.MaNhanVien = ma;
            this.TenNhanVien = ten;
            this.Luong1Gio = luong1gio;
            this.SoGioLamViec = sogio;
        }
        public int LuongNhanVien()
        {
            return this.SoGioLamViec * this.Luong1Gio;
        }
        public string Xuat()
        {
            return string.Format("\n{0}\t{1}\t{2}\t{3}\t{4}", this.MaNhanVien, this.TenNhanVien, this.Luong1Gio, this.SoGioLamViec, LuongNhanVien());
        }
    }
}
