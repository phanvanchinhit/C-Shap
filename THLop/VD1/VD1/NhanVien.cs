using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD1
{
    class NhanVien
    {
        private string _maNhanVien;
        private string _tenNhanVien;
        private int _luong1Gio;
        private int _soGioLam;
        public string maNhanVien
        {
            get
            {
                return _maNhanVien;
            }
            set
            {
                _maNhanVien = value;
            }
        }
        public string tenNhanVien
        {
            get
            {
                return _tenNhanVien;
            }
            set
            {
                _tenNhanVien = value;
            }
        }
        public int luong1Gio
        {
            get
            {
                return _luong1Gio;
            }
            set
            {
                _luong1Gio = value;
            }
        }
        public int soGioLam
        {
            get
            {
                return _soGioLam;
            }
            set
            {
                _soGioLam = value;
            }
        }
        public NhanVien() { }
        public NhanVien(string ma, string ten, int luong1gio, int sogiolam)
        {
            this.maNhanVien = ma;
            this.tenNhanVien = ten;
            this.luong1Gio = luong1gio;
            this.soGioLam = sogiolam;
        }

        public int TinhLuong()
        {
            return this.soGioLam * this.luong1Gio;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-15}{4,-20}", this.maNhanVien, this.tenNhanVien, this.luong1Gio, this.soGioLam, this.TinhLuong());
        }
    }
}
