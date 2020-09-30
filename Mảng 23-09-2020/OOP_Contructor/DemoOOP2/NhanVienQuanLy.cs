using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    class NhanVienQuanLy:NhanVien
    {
        private double _HeSoPhuCap;
        public double HeSoPhuCap
        {
            get
            {
                return _HeSoPhuCap;
            }
            set
            {
                _HeSoPhuCap = value;
            }
        }
        public NhanVienQuanLy() { }
        public NhanVienQuanLy(string ma, string ten, int luong1gio, int sogiolam, double hesophucap):base(ma, ten, luong1gio, sogiolam)
        {
            this.HeSoPhuCap = hesophucap;
        }

        public override double TinhLuong()
        {
            return this.SoGioLam * this.Luong1Gio * (1 + this.HeSoPhuCap);
        }
        public override string ToString()
        {
            return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-20}{4,-15}{5,-20}", this.MaNhanVien, this.TenNhanVien, this.Luong1Gio, this.SoGioLam, this.HeSoPhuCap, this.TinhLuong());
        }
    }
}
