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
   public class BUS_Diem
    {
        DAL_Diem d = new DAL_Diem();
        public void Insert(Diem diem)
        {
            d.Insert(diem);
        }
        public void Update(Diem diem)
        {
            d.Update(diem);
        }
        public void Delete(Diem diem)
        {
            d.Delete(diem);
        }
        public DataTable Load2(string sql)
        {
            return d.Load1(sql);
        }
    }
}
