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
    public partial class FrmThemHoaDon : Form
    {
        Khach khach = Khach.Instance;
        BLFood food = new BLFood();
        BLBill bill = new BLBill();
        BLBill_Detail billdetail = new BLBill_Detail();
        DataTable dtKhach = null;
        DataTable dtFood = null;
        bool check2;
        public FrmThemHoaDon()
        {
            InitializeComponent();
            loadDataKhach();
            loadDataFood();
            initListView();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadDataKhach()
        {
            dtKhach = new DataTable();
            dtKhach.Clear();
            dtKhach = khach.getKhach();

            //dua data len datagirdview\
            dgvListUsers.DataSource = dtKhach;

            //thay doi do rong cot
            dgvListUsers.AutoResizeColumns();
            /* try
             {
                 dtbill = new DataTable();
                 dtbill.Clear();
                 DataSet ds = blbill.LayThongTinDonHang();
                 dtbill = ds.Tables[0];
                 //dua data len datagirdview
                 dgvBanHang.DataSource = dtbill;
                 //thay doi do rong cot
                 dgvBanHang.AutoResizeColumns();
             }
             catch(SqlException)
             {
                 MessageBox.Show("Không lấy được thong tin don hang. Lỗi rồi!!!");
             } */
        }
        private void loadDataFood()
        {
            dtFood = new DataTable();
            dtFood.Clear();
            DataSet ds = food.LayDanhSachFood();

            dtFood = ds.Tables[0];

            //dua data len datagirdview\
            dgvListFood.DataSource = dtFood;

            //thay doi do rong cot
            dgvListFood.AutoResizeColumns();

        }

        private void btn_addBill_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = Int32.Parse(txb_userid.Text.Trim());
                int foodid = Int32.Parse(txb_foodid.Text.Trim());
                int counts = Int32.Parse(txb_counts.Text.Trim());
                string foodname = food.getNameFood(foodid);
                var item1 = new ListViewItem(new[] { foodid.ToString(), counts.ToString(), foodname });

                listViewFood.Items.Add(item1);
            }
            catch(Exception error)
            {
                MessageBox.Show("Vui lòng điền đầy đủ giá trị");
            }
            
            
            


            string err = "";
            //bool check = bill.UpdateBill(userid, foodid, counts, ref err);
            
            
            /*if (check)
            {

                    MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("error!!");
            } */

        }
        private void initListView()
        {
            // Add columns 
           
           
        }

        private void FrmThemHoaDon_Load(object sender, EventArgs e)
        {
            listViewFood.View = View.Details;
            listViewFood.GridLines = true;
            listViewFood.FullRowSelect = true;
            listViewFood.Columns.Add("FoodID",50);
            listViewFood.Columns.Add("counts",50);
            listViewFood.Columns.Add("Name", 120);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // button thanh toan
            try
            {
                int userid = Int32.Parse(txb_userid.Text.Trim());
                string totalcost = billdetail.LayTongTienTungUser(userid);
                if (check2)
                {

                    MessageBox.Show("Tổng tiền thanh toán là: " + totalcost);
                   
                }
                else
                {
                    MessageBox.Show("error!!");
                }
                string error = "";
                bool check = billdetail.updateStatusBillDetail(userid, ref error);
                loadDataKhach();
                if (error != "")
                {
                    MessageBox.Show(error);
                }
            }
            catch(Exception except)
            {
                MessageBox.Show("Vui lòng xác nhận trước khi thanh toán");
            }
            
            

        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = Int32.Parse(txb_userid.Text.Trim());
                string err = "";
                DateTime time = DateTime.Now;
                bool check = billdetail.insertBillDetail(0, time, userid, ref err);
              
                foreach (ListViewItem itemRow in listViewFood.Items)
                {

                    bool check1 = bill.insertBill(Int32.Parse(itemRow.SubItems[0].Text), Int32.Parse(itemRow.SubItems[1].Text), userid);

                }
                if (check)
                {

                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("error!!");
                }
                check2 = billdetail.ThanhToanBill(userid);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng thêm đơn trước khi xác nhận");
            }
            

        }
    }
}
