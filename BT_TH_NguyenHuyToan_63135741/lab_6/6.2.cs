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
    public partial class Form2 : Form
    {
        float a, b, c;
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton_PTB1.Checked = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_hsb_TextChanged(object sender, EventArgs e)
        {
            bool chka = float.TryParse(textBox_hsb.Text, out b);
            if (!chka)
                if (MessageBox.Show("Loi dinh dang\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_hsb.Clear();
                    textBox_hsb.Focus();
                }
        }

        private void textBox_hsc_TextChanged(object sender, EventArgs e)
        {
            bool chka = float.TryParse(textBox_hsc.Text, out c);
            if (!chka)
                if (MessageBox.Show("Loi dinh dang\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_hsc.Clear();
                    textBox_hsc.Focus();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            if (radioButton_PTB1.Checked)//PTB1
            {
                a = float.Parse(textBox_hsa.Text);
                b = float.Parse(textBox_hsb.Text);
                PTB1 pt1 = new PTB1(a, b);
                textBox_KQ.Text = pt1.Giai_WF();
            }
            if (radioButton_PTB2.Checked)//PTB2
            {
                a = float.Parse(textBox_hsa.Text);
                b = float.Parse(textBox_hsb.Text);
                c = float.Parse(textBox_hsc.Text);
                PTB2 pt2 = new PTB2(a, b, c);
                textBox_KQ.Text = pt2.Giai_WF();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_KQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_hsa.Clear();
            textBox_hsb.Clear();
            textBox_hsc.Clear();
            textBox_KQ.Clear();
        }

        private void radioButton_PTB2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PTB2.Checked)
                textBox_hsc.Enabled = true;
            else
                textBox_hsc.Enabled = false;

        }

        private void textBox_hsa_TextChanged(object sender, EventArgs e)
        {
            bool chka = float.TryParse(textBox_hsa.Text, out a);
            if (!chka)
                if (MessageBox.Show("Loi dinh dang\nBan muon nhap lai khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    textBox_hsa.Clear();
                    textBox_hsa.Focus();
                }
        }
    }
}
