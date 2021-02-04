using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FormThemKhach : Form
    {
        Khach khach = Khach.Instance;
        public FormThemKhach()
        {
            InitializeComponent();
        }

        private void FormThemKhach_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string id = textBoxID.Text.Trim();
                if (id.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập ID", "Alert");
                    break;
                }
                string name = textBoxName.Text.Trim();
                if (name.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập tên", "Alert");
                    break;
                }
                string phone = textBoxSDT.Text.Trim();
                if (phone.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập số điện thoại", "Alert");
                    break;
                }
                if (Khach.CheckUserID(int.Parse(id)))
                {
                    MessageBox.Show("Id được chọn đã tồn tại", "Alert");
                    break;
                }
                
                string uname = textBoxuname.Text;
                if (uname.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập tên tài khoản", "Alert");
                    break;
                }
                string pass = textBoxpass.Text;
                if (pass.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Alert");
                    break;
                }
                if (Khach.CheckUserName(uname))
                {
                    MessageBox.Show("Tên tài khoản đã có trong database", "Alert");
                    break;
                }
                string rank = comboBoxRank.Text;
                int point = (int)numericUpDownpoint.Value;
                string bdate = dateTimePickerdate.Value.ToString("yyyy-MM-dd");
                Random rnd = new Random();
                int i = rnd.Next(100,1000);
                
                //MessageBox.Show(id + " " + name + " " + type + " " + pro + " " + count + " " + cost + " " + date);
                string a = khach.AddKhach(id,name,rank,point,bdate,phone,i,uname,pass);
                MessageBox.Show(a);
                break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
