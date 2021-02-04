using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyQuanTS
{
    public partial class FormEdiRemoveKhack : Form
    {
        Khach khach = Khach.Instance;
        public FormEdiRemoveKhack()
        {
            InitializeComponent();
        }
        public FormEdiRemoveKhack(string id,string phone,string name,string bday,string rank,string point)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxSDT.Text = phone;
            for (int i = 0; i < comboBoxRank.Items.Count; i++)
            {
                if (comboBoxRank.GetItemText(comboBoxRank.Items[i]) == rank)
                {
                    comboBoxRank.SelectedIndex = i;
                    break;
                }
            }
            numericUpDownpoint.Value = int.Parse(point);
            dateTimePickerdate.Value = DateTime.ParseExact(bday, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
        private void FormEdiRemoveKhack_Load(object sender, EventArgs e)
        {

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
                string rank = comboBoxRank.Text;
                int point = (int)numericUpDownpoint.Value;
                string bdate = dateTimePickerdate.Value.ToString("yyyy-MM-dd");
                string a = khach.EditKhach(id, name, rank, point, bdate, phone);
                MessageBox.Show(a);
                this.Close();
                break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xóa ?","Xóa ?",MessageBoxButtons.OKCancel);
            if (a==DialogResult.OK)
            {
                string id = textBoxID.Text;
                string b = khach.DeleteKhach(id);
                MessageBox.Show(b);
                this.Close();
            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
