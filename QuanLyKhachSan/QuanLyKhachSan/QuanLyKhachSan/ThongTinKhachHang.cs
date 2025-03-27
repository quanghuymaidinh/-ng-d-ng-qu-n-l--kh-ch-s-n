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

namespace QuanLyKhachSan
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string qr = "select * from KhachHang";
            dGVThongTinKhachHang.DataSource = ketnoi.Execute(qr);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBox();
        }

        private void dGVThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThongTinKhachHang.CurrentRow.Index;
            txtMaKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[1].Value.ToString();
            cBGioiTinh.Text = dGVThongTinKhachHang.Rows[index].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dGVThongTinKhachHang.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dGVThongTinKhachHang.Rows[index].Cells[4].Value.ToString();
            txtSoDienThoai.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
            txtCMND.Text = dGVThongTinKhachHang.Rows[index].Cells[6].Value.ToString();
            cBTimKiemTheoKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = txtMaKhachHang.Text;
                string hoTen = txtTenKhachHang.Text;
                string phai = cBGioiTinh.SelectedItem.ToString();
                string ngaySinh = dtpNgaySinh.Text; // Dùng Value thay vì ToString để đảm bảo đúng kiểu DateTime
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string cmND = txtCMND.Text;

                // Kiểm tra dữ liệu đầu vào, đảm bảo rằng tất cả các trường đều không trống
                if (string.IsNullOrWhiteSpace(maKhachHang) ||
                    string.IsNullOrWhiteSpace(hoTen) ||
                    string.IsNullOrWhiteSpace(phai) ||
                    string.IsNullOrWhiteSpace(diaChi) ||
                    string.IsNullOrWhiteSpace(soDienThoai) ||
                    string.IsNullOrWhiteSpace(cmND))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO KhachHang (MaKhachHang, HoTen, Phai, NgaySinh, DiaChi, SoDienThoai, CMND_Passport) " +
                               "VALUES (@MaKhachHang, @HoTen, @Phai, @NgaySinh, @DiaChi, @SoDienThoai, @CMND_Passport)";

                ketnoi.GetThem(query, maKhachHang, hoTen, phai, ngaySinh, diaChi, soDienThoai, cmND);

                loaddata();
                LoadComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {          
                string query = "DELETE FROM KhachHang WHERE MaKhachHang = '" + txtMaKhachHang.Text + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Dữ liệu đã được xóa thành công.");
            }
            else
            {
                MessageBox.Show("Dữ liệu không được xóa.");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = txtMaKhachHang.Text;
                string hoTen = txtTenKhachHang.Text;
                string phai = cBGioiTinh.SelectedItem.ToString();
                string ngaySinh = dtpNgaySinh.Text; 
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string cmND = txtCMND.Text;
                    
                string query = "UPDATE KhachHang SET HoTen = @HoTen, Phai = @Phai, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, CMND_Passport = @CMND_Passport WHERE MaKhachHang = @MaKhachHang";

                ketnoi.GetSua(query, maKhachHang, hoTen, phai, ngaySinh, diaChi, soDienThoai, cmND);

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {  
            
            string query = "SELECT * FROM KhachHang WHERE (SoDienThoai LIKE '%" + cBTimKiemTheoKhachHang.Text + "%')";
            DataTable dt = ketnoi.GetTimKiem(query);

            if (dt.Rows.Count > 0)
            {
                dGVThongTinKhachHang.DataSource = dt;
                int index = dGVThongTinKhachHang.CurrentRow.Index;
                txtMaKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVThongTinKhachHang.Rows[index].Cells[1].Value.ToString();
                cBGioiTinh.Text = dGVThongTinKhachHang.Rows[index].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dGVThongTinKhachHang.Rows[index].Cells[3].Value.ToString();
                txtDiaChi.Text = dGVThongTinKhachHang.Rows[index].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dGVThongTinKhachHang.Rows[index].Cells[5].Value.ToString();
                txtCMND.Text = dGVThongTinKhachHang.Rows[index].Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadComboBox()
        {
            string qr = "SELECT SoDienThoai FROM KhachHang";
            DataTable dt = ketnoi.Execute(qr);

            if (dt.Rows.Count > 0)
            {
                cBTimKiemTheoKhachHang.DisplayMember = "SoDienThoai";
                cBTimKiemTheoKhachHang.ValueMember = "MaKhachHang";
                cBTimKiemTheoKhachHang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
