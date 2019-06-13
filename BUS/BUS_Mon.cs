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
    public class BUS_Mon
    {
        DAL_Mon mon1 = new DAL_Mon();
        public void Insert(Mon m)
        {
            mon1.Insert(m);
        }
        public void Update(Mon m)
        {
            mon1.Update(m);
        }
        public void Delete(Mon m)
        {
            mon1.Delete(m);
        }
        public DataTable Load2(string sql)
        {
            return mon1.Load1(sql);
        }
    }
}
