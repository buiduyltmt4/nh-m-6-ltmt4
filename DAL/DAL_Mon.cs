using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Mon : DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);//Load cua lop DBConnect
        }
        public void Insert(Mon mon1)
        {
            string sql = "insert into mon values('" +
                mon1.Mamon + "','" + mon1.Tenmon + "' ,'" +
                mon1.Sotc + "')";

            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(Mon mon1)
        {
            string sql = "update mon set Hoten ='" +
                   mon1.Tenmon + "',sotc='" + mon1.Sotc + "' where mamon = '" +
                   mon1.Mamon + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(Mon mon1)
        {
            string sql = "delete from mon where mamon='" + mon1.Mamon + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
