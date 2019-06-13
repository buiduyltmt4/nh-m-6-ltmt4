using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Diem
    {
        string masv;
        string mamon;
        float diem;
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public string Mamon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        public float D
        {
            get { return diem; }
            set { diem = value; }
        }
        public Diem() { }
        public Diem(string masv, string mamon, float diem)
        {
            this.Masv = masv;
            this.Mamon = mamon;
            this.D = diem;
        }
        
      
    }
}
