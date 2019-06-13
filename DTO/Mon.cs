using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Mon
    {
        string mamon;
        string tenmon;
        string sotc;
        public string Mamon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        public string Tenmon
        {
            get{ return tenmon;}
            set { tenmon = value; }
        }
        public string Sotc
        {
            get { return sotc; }
            set { sotc = value; }
        }
        public Mon(string mamon, string tenmon, string sotc)
        {
            this.Mamon = mamon;
            this.Tenmon = tenmon;
            this.Sotc = sotc;
        }
        public Mon() { }
    }
}
