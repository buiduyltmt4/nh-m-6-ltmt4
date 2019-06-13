using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_Sinhvien
    {
        DAL_Sinhvien sv = new DAL_Sinhvien();
        public void Insert(Sinhvien s)
        {
            sv.Insert(s);
        }
        public void Update(Sinhvien s)
        {
            sv.Update(s);
        }
        public void Delete(Sinhvien s)
        {
            sv.Delete(s);
        }
        public DataTable Load2(string sql)
        {
            return sv.Load1(sql);
        }
    }
}
