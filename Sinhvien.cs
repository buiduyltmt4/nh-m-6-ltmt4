using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sinhvien
    {
        string masv;
        string hoten;
        string ngaysinh;
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public Sinhvien(string ma, string ht, string ns)
        {
            this.Masv = ma;
            this.Hoten = ht;
            this.Ngaysinh = ns;
        }
        public Sinhvien() { }
    }
}
