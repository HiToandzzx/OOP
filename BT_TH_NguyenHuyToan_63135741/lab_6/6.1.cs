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
    public partial class Form1 : Form
    {
        float a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // NUT RESET
        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_Nhapa.Clear();
            textBox_Nhapb.Clear();
            textBox_KQ.Clear();
        }

        // PHEP TRU
        private void button_Tru_Click(object sender, EventArgs e)
        {
            textBox_KQ.Text = (a - b).ToString();
        }

        // PHEP CHIA
        private void button_Chia_Click(object sender, EventArgs e)
        {
            textBox_KQ.Text = (a / b).ToString();
        }

        // PHEP NHAN
        private void button_Nhan_Click(object sender, EventArgs e)
        {
            textBox_KQ.Text = (a * b).ToString();
        }

        // PHEP CONG
        private void button_Cong_Click(object sender, EventArgs e)
        {
            textBox_KQ.Text = (a + b).ToString();
        }

        private void textBox_Nhapa_TextChanged(object sender, EventArgs e)
        {
            bool chka = float.TryParse(textBox_Nhapa.Text, out a);
            if (!chka) 
                if (MessageBox.Show("Loi dinh dang\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_Nhapa.Clear();
                    textBox_Nhapa.Focus();
                }
        }

        private void textBox_Nhapb_TextChanged(object sender, EventArgs e)
        {
            bool chkb = float.TryParse(textBox_Nhapb.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Loi dinh dang\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_Nhapb.Clear();
                    textBox_Nhapb.Focus();
                }
        }

        private void textBox_KQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
