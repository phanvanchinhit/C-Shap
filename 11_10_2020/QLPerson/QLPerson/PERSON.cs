using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPerson
{
    class PERSON
    {
        private string _hoTen;
        private string _gioiTinh;
        private int _namSinh;
        private string _diaChi;
          
        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return _namSinh;
            }

            set
            {
                _namSinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public PERSON() { }
        public PERSON(string hoten, string gioitinh, int namsinh, string diachi)
        {
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.NamSinh = namsinh;
            this.DiaChi = diachi;
        }

        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-15}{2,-15}{3,-15}", this.HoTen, this.GioiTinh, this.NamSinh, this.DiaChi);
        }
    }
}
