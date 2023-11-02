using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bàiTậpĐiềuKhiểnThườngDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muon Thoat CT?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bài61ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void bài62ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void bài63ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }
    }
}
