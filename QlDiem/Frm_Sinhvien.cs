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
    public partial class Frm_Sinhvien : Form
    {
        public Frm_Sinhvien()
        {
            InitializeComponent();
        }
        BUS_Sinhvien sv = new BUS_Sinhvien();

        private void Frm_Sinhvien_Load(object sender, EventArgs e)
        {
            string sql = "Select * from sv";
            dataGridView1.DataSource = sv.Load2(sql);
            txtHoten.Text = "";
            txtMasv.Text = "";
            txtNgaysinh.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(txtMasv.Text, txtHoten.Text, txtNgaysinh.Text);
            sv.Insert(ob);
            Frm_Sinhvien_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(txtMasv.Text, txtHoten.Text, txtNgaysinh.Text);
            sv.Update(ob);
            Frm_Sinhvien_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(txtMasv.Text, txtHoten.Text, txtNgaysinh.Text);
            sv.Delete(ob);
            Frm_Sinhvien_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMasv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtNgaysinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

         
    }
}
