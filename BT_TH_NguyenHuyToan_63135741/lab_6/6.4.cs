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

    public partial class Form4 : Form
    {
        // KHOI TAO DANH SACH
        List<User> ls;

        public Form4()
        {
            InitializeComponent();
            ls = new List<User>();
            Read_File();
        }

        // DOC FILE
        void Read_File()
        {
            try
            {
                FileStream f = new FileStream("C:\\Users\\Admin\\Desktop\\S\\OOP\\BT_TH_NguyenHuyToan_63135741\\lab_6\\bin\\User.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//2 phan tu trong item
                    string m = item[0];
                    string t = item[1];
                    User us = new User(m, t);
                    ls.Add(us);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //tìm trong list xem có user có tên = text trong txtusernam không, kết quả tìm kiếm trả về trong u1, nếu u1 = null nghĩa là không có username trong list
            //u2 lưu kết quả tìm đối tượng có password = txtPass trong list
            User u1 = ls.Find(s => s.Name == txtUserName.Text);
            User u2 = ls.Find(s => s.Pass == txtPass.Text);

            if (u1 != null) //nếu có user thỏa mãn username
            {
                if (u2 != null) //nếu có user thỏa mãn password
                {
                    MessageBox.Show("Logged in successfully!");
                    Close();
                }
                else //nếu không có user thỏa mãn password
                   if (MessageBox.Show("Invalid password!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtPass.Clear();
                    txtPass.Focus();
                }
                else
                    Application.Exit();
            }
            else //nếu không có user thỏa mãn username
                if (MessageBox.Show("Invalid username!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                txtUserName.Clear();
                txtUserName.Focus();
            }
            else
                Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
