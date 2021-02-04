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
    public partial class FormThemKho : Form
    {
        Kho kho = Kho.Instance;
        public FormThemKho()
        {
            InitializeComponent();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
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
                string cost = textBoxCost.Text.Trim();
                if (cost.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập giá", "Alert");
                    break;
                }
                if (Kho.CheckInputStoreID(int.Parse(id)))
                {
                    MessageBox.Show("Id được chọn đã tồn tại", "Alert");
                    break;
                }
                string type = comboBoxtype.Text;
                string pro = comboBoxPro.Text;
                string count = numericUpDowncount.Value.ToString();
                string date = dateTimePickerdate.Value.ToString("yyyy-MM-dd");
                string intproid = kho.GetProviderID(pro).ToString();

                //MessageBox.Show(id + " " + name + " " + type + " " + pro + " " + count + " " + cost + " " + date);
                string err = "";
                string a = kho.AddKho(id, name, type, count, cost, date, intproid, ref err);
                MessageBox.Show(a);
                break;

            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemKho_Load(object sender, EventArgs e)
        {
            comboBoxtype.DataSource = kho.getType();
            comboBoxtype.SelectedIndex = 0;
            comboBoxtype.DisplayMember = "name";
            dateTimePickerdate.MinDate = DateTime.Today;
            comboBoxPro.DataSource = kho.getPro();
            comboBoxPro.SelectedIndex = 0;
            comboBoxPro.DisplayMember = "name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
