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
    public partial class FormEditRemoveKho : Form
    {
        Kho kho = Kho.Instance;
        public FormEditRemoveKho()
        {
            InitializeComponent();
        }
        public FormEditRemoveKho(string id, string name, string type, string count, string intcost, string date, string pro)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxName.Text = name;
            for(int i=0;i<comboBoxtype.Items.Count;i++)
            {
                if(comboBoxtype.GetItemText(comboBoxtype.Items[i])==type)
                {
                    comboBoxtype.SelectedIndex = i;
                    break;
                }
            }
            numericUpDowncount.Value = int.Parse(count);
            textBoxCost.Text = intcost;
            dateTimePickerdate.Value= DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            for (int i = 0; i < comboBoxPro.Items.Count; i++)
            {
                if (comboBoxPro.GetItemText(comboBoxPro.Items[i]) == type)
                {
                    comboBoxPro.SelectedIndex = i;
                    break;
                }
            }

        }

        private void FormEditRemoveKho_Load(object sender, EventArgs e)
        {
            comboBoxtype.DataSource = kho.getType();
            comboBoxtype.SelectedIndex = 0;
            comboBoxtype.DisplayMember = "name";
            comboBoxPro.DataSource = kho.getPro();
            comboBoxPro.SelectedIndex = 0;
            comboBoxPro.DisplayMember = "name";
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
              
                string type = comboBoxtype.Text;
                string pro = comboBoxPro.Text;
                string count = numericUpDowncount.Value.ToString();
                string date = dateTimePickerdate.Value.ToString("yyyy-MM-dd");
                string intproid = kho.GetProviderID(pro).ToString();

                //MessageBox.Show(id + " " + name + " " + type + " " + intproid + " " + count + " " + cost + " " + date);
                string err = "";
                string a = kho.EditKho(id, name, type, count, cost, date, intproid, ref err);
                MessageBox.Show(a);
                this.Close();
                break;

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            string err = "";
            string a = kho.DeleteKho(id,ref err);
            MessageBox.Show(a);
            this.Close();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
