using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Contructor
{
    class NhanVien
    {
        private string _MaNhanVien;
        private string _TenNhanVien;
        private int _Luong1Gio;
        private int _SoGioLam;
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
        public int Luong1Gio
        {
            get
            {
                return _Luong1Gio;
            }
            set
            {
                _Luong1Gio =value;
            }
        }
        public int SoGioLam
        {
            get
            {
                return _SoGioLam;
            }
            set
            {
                _SoGioLam = value;
            }
        }
        public NhanVien()
        {

        }
        public NhanVien(string ma, string ten, int luong1gio, int sogiolam)
        {
            this.MaNhanVien = ma;
            this.TenNhanVien = ten;
            this.Luong1Gio = luong1gio;
            this.SoGioLam = sogiolam;
        }
        public int TinhLuong()
        {
            return this.SoGioLam * this.Luong1Gio;
        }
        public override string ToString()
        {
            return string.Format("\n{0}\t{1}\t{2}\t{3}\t{4}", this.MaNhanVien, this.TenNhanVien, this.Luong1Gio, this.SoGioLam, this.TinhLuong());
        }


    }
}
