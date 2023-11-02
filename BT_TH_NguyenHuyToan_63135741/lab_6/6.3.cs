using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form3 : Form
    {
        // KHOI TAO DANH SACH HINH ANH
        List<Phone> ls;
        string pic;//duong dan toi 1 hinh anh

        public Form3()
        {
            InitializeComponent();
        }

        // DOC FILE
        void Read_File()
        {
            try
            {
                FileStream f = new FileStream("C:\\Users\\Admin\\Desktop\\S\\OOP\\BT_TH_NguyenHuyToan_63135741\\lab_6\\Phone.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh               

                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//4 phan tu trong item
                    string m = item[0];//ma
                    string h = item[1];//nhan hieu
                    float p = float.Parse(item[2]);//gia nhap
                    string pic = item[3];//duong dan toi file hinh
                    Phone phone = new Phone(m, h, p, pic);
                    ls.Add(phone);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            ls = new List<Phone>();
            Read_File();
            dgvDSDT.DataSource = ls;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = txtMaSo.Text;
            string h = cmbNhanHieu.Text;
            float gn = float.Parse(txtGiaNhap.Text);

            Phone p = new Phone(m, h, gn, pic);
            ls.Add(p);
            dgvDSDT.DataSource = null;
            dgvDSDT.DataSource = ls;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = ofd.FileName;
                picDienThoai.Image = Image.FromFile(pic);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < ls.Count; i++)
                if (txtMaSo.Text == ls[i].Id)
                    break;
            if (i < ls.Count)
            {
                ls.RemoveAt(i);
                txtMaSo.Clear();
                dgvDSDT.DataSource = null;
                dgvDSDT.DataSource = ls;
            }
        }

        private void btnTinhGia_Click(object sender, EventArgs e)
        {
            Phone ph = ls.Find(p => p.Id == txtMaSo.Text);
            if (ph != null)
                txtGiaBan.Text = ph.Sale().ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            ls.Sort();
            dgvDSDT.DataSource = null;
            dgvDSDT.DataSource = ls;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDSDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

