using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bảngSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sinhvien f = new Frm_Sinhvien();
            f.Show();
        }

        private void bảngMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mon f = new Frm_Mon();
            f.Show();
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Diem f = new Frm_Diem();
            f.Show();
        }

       
    }
}
