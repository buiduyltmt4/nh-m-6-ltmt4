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
namespace QLDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUS_Sinhvien sv = new BUS_Sinhvien();
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Select * from sv";
            dataGridView1.DataSource = sv.Load2(sql);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
       

       

        private void Button1_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(textBox1.Text, textBox2.Text, textBox3.Text);
            sv.Insert(ob);
            Form1_Load(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(textBox1.Text, textBox2.Text, textBox3.Text);
            sv.Update(ob);
            Form1_Load(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Sinhvien ob = new Sinhvien(textBox1.Text, textBox2.Text, textBox3.Text);
            sv.Delete(ob);
            Form1_Load(sender, e);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
