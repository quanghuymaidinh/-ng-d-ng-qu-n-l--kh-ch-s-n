using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DatPhong : Form
    {
        KetNoi ketnoi = new KetNoi();
        public DatPhong()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string str = "select * from DatPhong";
            dGVDatPhong.DataSource = ketnoi.Execute(str);
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {       
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                
                string maDatPhong = txtMaDatPhong.Text;    
                string maKhachHang = txtMaKhachHang.Text;
                string maPhong = txtMaPhong.Text; 
                string maNhanVien = txtMaNhanVien.Text;
                string ngayDen = dtpNgayDen.Text;
                string ngayDi = dtpNgayDi.Text;

                // Kiểm tra dữ liệu đầu vào, đảm bảo rằng tất cả các trường đều không trống
                if (
                    string.IsNullOrWhiteSpace(maDatPhong) ||
                    string.IsNullOrWhiteSpace(maPhong) ||
                    string.IsNullOrEmpty(maKhachHang) ||
                    string.IsNullOrWhiteSpace(maNhanVien) ||
                    string.IsNullOrWhiteSpace(ngayDi) ||
                    string.IsNullOrWhiteSpace(ngayDen))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO DatPhong (MaDatPhong,maKhachHang, MaPhong,MaNhanVien, NgayDen, NgayDi) " +
                            "VALUES (@MaDatPhong, @maKhachHang,@MaPhong , @MaNhanVien, @NgayDen, @NgayDi)";
                ketnoi.GetDatPhong(query, maDatPhong, maKhachHang,maPhong, maNhanVien, ngayDen, ngayDi);
                loaddata();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gBThongTinDatPhong_Enter(object sender, EventArgs e)
        {

        }
    }
}
