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
    public partial class Frm_Mon : Form
    {
        public Frm_Mon()
        {
            InitializeComponent();
        }
        BUS_Mon mon1 = new BUS_Mon();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Mon ob = new Mon(txtMamon.Text, txtTenmon.Text, txtSOTC.Text);
            mon1.Insert(ob);
            Frm_Mon_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Mon ob = new Mon(txtMamon.Text, txtTenmon.Text, txtSOTC.Text);
            mon1.Update(ob);
            Frm_Mon_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Mon ob = new Mon(txtMamon.Text, txtTenmon.Text, txtSOTC.Text);
            mon1.Delete(ob);
            Frm_Mon_Load(sender, e);
        }

        private void Frm_Mon_Load(object sender, EventArgs e)
        {
            string sql = "Select * from mon";
            dataGridView1.DataSource = mon1.Load2(sql);
            txtTenmon.Text = "";
            txtMamon.Text = "";
            txtSOTC.Text = "";
        }
        private void dt1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMamon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenmon.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSOTC.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        
    }
}
