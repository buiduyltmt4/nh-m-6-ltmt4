
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class DAL_Sinhvien:DBConnect
    {
       public DataTable Load1(string sql)
       {
           return Load(sql);//Load cua lop DBConnect
       }
       public void Insert(Sinhvien sv1)
       {
           string sql = "insert into sv values('" +
               sv1.Masv + "','" + sv1.Hoten + "' ,'" +
               sv1.Ngaysinh + "')";
           
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }
       public void Update(Sinhvien sv1)
       {
           string sql = "update sv set hoten ='" +
                  sv1.Hoten + "',ngaysinh='" + sv1.Ngaysinh + "' where masv = '" +
                  sv1.Masv + "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }
       public void Delete(Sinhvien sv1)
       {
           string sql = "delete from sv where masv='" + sv1.Masv+ "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
           DataTable dt = new DataTable();
           da.Fill(dt);
           da.Update(dt);
           dt.AcceptChanges();
       }

    }
}
