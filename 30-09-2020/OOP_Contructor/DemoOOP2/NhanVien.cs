﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    class NhanVien
    {
        private string _MaNhanVien;
        private string _TenNhanVien;
        private int _SoGioLam;
        private int _Luong1Gio;
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
                _Luong1Gio = value;
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
        public NhanVien (string ma, string ten, int luong1gio,int sogiolam)
        {
            this.MaNhanVien = ma;
            this.TenNhanVien = ten;
            this.Luong1Gio = luong1gio;
            this.SoGioLam = sogiolam;
        }
        public NhanVien() {  }
        public virtual double TinhLuong()
        {
            return this.SoGioLam * this.Luong1Gio;
        }
        public double TinhLuong(int luong1gio , int sogiolam)
        {
            return luong1gio * sogiolam;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-20}{4,-15}{5,-20}",this.MaNhanVien, this.TenNhanVien, this.Luong1Gio, this.SoGioLam,0, this.TinhLuong());
        }

    }
}
