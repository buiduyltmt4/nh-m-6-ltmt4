using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QlDiem
{
    public partial class Frm_Diem : Form
    {
        public Frm_Diem()
        {
            InitializeComponent();
        }
        BUS_Diem d = new BUS_Diem();
        BUS_Sinhvien s = new BUS_Sinhvien();
        BUS_Mon m = new BUS_Mon();
        private void Frm_Diem_Load(object sender, EventArgs e)
        {
            string sql = "select * from sv";
            DataTable dt = new DataTable();
            dt = s.Load2(sql);
            cboMasv.DataSource = dt;
            cboMasv.DisplayMember = "Masv";
            cboMasv.ValueMember = "Masv";

            string sql1 = "select * from mon";
            DataTable dt1 = new DataTable();
            dt1 = m.Load2(sql1);
            cboMamon.DataSource = dt1;
            cboMamon.DisplayMember = "Mamon";
            cboMamon.ValueMember = "Mamon";

            string sql2 = "select * from diem";
            dataGridView1.DataSource = d.Load2(sql2);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        Diem ob = new Diem(cboMasv.Text , cboMamon.Text, float.Parse(txtDiem.Text));
            d.Insert(ob);
            Frm_Diem_Load(sender , e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             Diem ob = new Diem(cboMasv.Text , cboMamon.Text, float.Parse(txtDiem.Text));
            d.Update(ob);
            Frm_Diem_Load(sender , e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             Diem ob = new Diem(cboMasv.Text , cboMamon.Text, float.Parse(txtDiem.Text));
            d.Delete(ob);
            Frm_Diem_Load(sender , e);
        }

        private void dt2(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cboMasv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cboMamon.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiem.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
