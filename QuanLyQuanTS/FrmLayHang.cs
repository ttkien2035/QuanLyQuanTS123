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
    public partial class FrmLayHang : Form
    {
        Kho kho = Kho.Instance;
        int oldCount = 0;
        public FrmLayHang()
        {
            InitializeComponent();
        }
        public FrmLayHang(string id, string name, string type, string count, string intcost,  string pro)
        {
            InitializeComponent();
            textBox_ID.Text = id;
            textBox_Name.Text = name;
            textBox_Type.Text = type;
            textBox_Count.Text = count;
            textBox_Cost.Text = intcost;
            textBox_Pro.Text = pro;
            oldCount = Int32.Parse(intcost);

        }

        private void FrmLayHang_Load(object sender, EventArgs e)
        {

        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            while (true)
            {


                string cost1 = textBox_Cost.Text.Trim();
                if (cost1.Length <= 0)
                {
                    MessageBox.Show("Chưa nhập giá", "Alert");
                    break;
                }

                string id = textBox_ID.Text;
                string name = textBox_Name.Text;
                string type = textBox_Type.Text;
                string count = textBox_Count.Text.Trim();
                int newcount = Int32.Parse(count);
                string cost = textBox_Cost.Text;

                string pro = textBox_Pro.Text;


                //MessageBox.Show(id + " " + name + " " + type + " " + intproid + " " + count + " " + cost + " " + date);
                if (newcount <= oldCount)
                {
                    bool a = kho.UpdateKho(id, count);
                    if (a)
                        MessageBox.Show("Lấy hàng thành công");
                    else
                        MessageBox.Show("Số hàng lấy lớn hơn trong kho");
                }
               
                this.Close();
                break;
            }
                
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
