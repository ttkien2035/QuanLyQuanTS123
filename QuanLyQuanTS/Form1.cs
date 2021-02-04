using QuanLyQuanTS.BS_Layer;

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

    public partial class Form1 : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public Form1(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            AnNut();
            ChangeAccount(acc);
        }

        

        void ChangeAccount(Account acc)
        {
            if (acc.Type.ToString() == "admin")
            {
                btnAdmin.Visible = true;
                btnKhachHang.Visible = true;
                btnNhanVien.Visible = true;
            }
            else if (acc.Type.ToString() == "staff")
            {
                btnAdmin.Visible = false;
                btnKhachHang.Visible = true;
                btnNhanVien.Visible = true;
            }
            else if (acc.Type.ToString() == "customer")
            {
                btnAdmin.Visible = false;
                btnKhachHang.Visible = true;
                btnNhanVien.Visible = false;
            }
        }
        private void AnNut()
        {
            //panelQuanLyKhachHang.Visible = false;
            panelQuanLyKho.Visible = false;
            panelTaiKhoan.Visible = false;
            panelQuanLySp.Visible = false;
        }

        private void AnNutMenu()
        {
            
            if (panelQuanLyKho.Visible == true)
            {
                panelQuanLyKho.Visible = false;
            }
            if (panelTaiKhoan.Visible == true)
            {
                panelTaiKhoan.Visible = false;
            }
            if (panelQuanLySp.Visible == true)
            {
                panelQuanLySp.Visible = false;
            }
        }

        private void HienNutMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                AnNutMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan a = new FrmTaiKhoan(loginAccount);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btnQuanLyDN_Click(object sender, EventArgs e)
        {
            HienNutMenu(panelTaiKhoan);
        }

        private void btnThayDoiTT_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThemTaiKhoan());
        }

        private void btnQuanLySp_Click(object sender, EventArgs e)
        {
            HienNutMenu(panelQuanLySp);
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            HienNutMenu(panelQuanLyKho);
        }

        /*private void btnQLKH_Click(object sender, EventArgs e)
        {
            HienNutMenu(panelQuanLyKhachHang);
        }*/

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnXemSp_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmXuatKho());
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLSP());
        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLKhachHang());
        }

        private void btnQLXuatKho_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLKho());
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLSP());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBanHang());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSanPham());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLKhachHang());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmQLKhachHang());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThemTaiKhoan());
        }
    }
}
