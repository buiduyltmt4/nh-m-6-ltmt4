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
   public class DAL_Diem : DBConnect
    {
       public DataTable Load1(string sql)
       {
           return Load(sql);
       }
       public void Insert(Diem d)
       {
           string sql = "insert into diem values('"+d.Masv + "','" + d.Mamon + "','" + d.D + "')";
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }
       public void Update(Diem d)
       {
           string sql = "update diem set diem.diem=" + d.D + "where masv='";
           sql += d.Masv.Trim() + "' and mamon ='" + d.Mamon.Trim() + "'";
                  
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }
       public void Delete(Diem d)
       {
           string sql = "delete from diem where masv='" + d.Masv.Trim() + "' and mamon ='"
               +d.Mamon.Trim()+"'";
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }

    }
}
