
using QuanLyQuanTS.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FrmQLSP : Form
    {
        DataTable dtSanPham = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;
        string err;
        BLFood dbSP = new BLFood();
        public FrmQLSP()
        {

            InitializeComponent();
            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()//Load Danh Sách Bàn và đổi tên cho các cột
        {
            try
            {
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                DataSet ds = dbSP.LayDanhSachFood();
                dtSanPham = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvSanPham.DataSource = dtSanPham;
                // Thay đổi độ rộng cột
                dgvSanPham.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtFoodName.ResetText();
                this.txtFoodId.ResetText();
                this.txtCategory.ResetText();
                this.TxtGia.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                //this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnReload.Enabled = true;
                //
                //dgvTHANHPHO_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sản Phẩm. Lỗi rồi!!!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng 
            this.txtFoodName.ResetText();
            this.txtFoodId.ResetText();
            this.txtCategory.ResetText();
            this.TxtGia.ResetText();
            this.txtFoodId.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnReload.Enabled = false;
            // Đưa con trỏ 
            this.txtFoodId.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnReload.Enabled = false;
            // Đưa con trỏ 
            this.txtFoodName.ResetText();
            this.txtCategory.ResetText();
            this.TxtGia.ResetText();
            this.txtFoodId.Focus();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvSanPham.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtFoodId.Text =
            dgvSanPham.Rows[r].Cells[0].Value.ToString();
            this.txtFoodName.Text =
            dgvSanPham.Rows[r].Cells[1].Value.ToString();
            this.txtCategory.Text =
            dgvSanPham.Rows[r].Cells[2].Value.ToString();
            this.TxtGia.Text =
            dgvSanPham.Rows[r].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtFoodName.ResetText();
            this.txtFoodId.ResetText();
            this.txtCategory.ResetText();
            this.TxtGia.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnReload.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgvSanPham_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLFood blSanPham = new BLFood();
                    blSanPham.ThemFood(int.Parse(txtFoodId.Text.ToString()), this.txtFoodName.Text, int.Parse(TxtGia.Text.ToString()), int.Parse(txtCategory.Text.ToString()), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLFood blSanPham = new BLFood();
                blSanPham.CapNhatFood(int.Parse(txtFoodId.Text.ToString()), this.txtFoodName.Text, int.Parse(TxtGia.Text.ToString()), int.Parse(txtCategory.Text.ToString()), ref err);

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvSanPham.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string stringSanPham =
                dgvSanPham.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbSP.XoaFood(ref err, int.Parse(stringSanPham.ToString()));
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void FrmQLSP_Load(object sender, EventArgs e)
        {

        }
    }
}
