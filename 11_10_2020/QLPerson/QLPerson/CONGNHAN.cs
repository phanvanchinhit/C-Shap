using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPerson
{
    class CONGNHAN:PERSON
    {
        private string _tenCongTy;
        private string _ngayVaoLamViec;
        private double _heSoLuong;

        public string TenCongTy
        {
            get
            {
                return _tenCongTy;
            }

            set
            {
                _tenCongTy = value;
            }
        }

        public string NgayVaoLamViec
        {
            get
            {
                return _ngayVaoLamViec;
            }

            set
            {
                _ngayVaoLamViec = value;
            }
        }

        public double HeSoLuong
        {
            get
            {
                return _heSoLuong;
            }

            set
            {
                _heSoLuong = value;
            }
        }
        public CONGNHAN() { }
        public CONGNHAN( string hoten , string gioitinh, int namsinh, string diachi, string tencongty, string ngayvaolam, double hesoluong):base(hoten, gioitinh, namsinh, diachi)
        {
            this.TenCongTy = tencongty;
            this.NgayVaoLamViec = ngayvaolam;
            this.HeSoLuong = hesoluong;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", this.HoTen, this.GioiTinh, this.NamSinh, this.DiaChi, this.TenCongTy, this.NgayVaoLamViec, this.HeSoLuong);
        }
    }
}
