using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThanhToan : Form
    {
        KetNoi ketnoi = new KetNoi();
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBox();
        }

        void loaddata()
        {
            string qr = "select * from KhachHang JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang";
            dGVThanhToan.DataSource = ketnoi.Execute(qr);
        }
        
        private void LoadComboBox()
        {
            string qr = "SELECT SoDienThoai FROM KhachHang JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang";
            DataTable dt = ketnoi.Execute(qr);

            if (dt.Rows.Count > 0)
            {
                cBSDTKH.DisplayMember = "SoDienThoai";
                cBSDTKH.ValueMember = "SoDienThoai";
                cBSDTKH.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhachHang.Text; 
            string maThuePhong = lblMaTP.Text;

            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string query = @"
            SELECT 
            kh.MaKhachHang,
            kh.HoTen,
            p.GiaCoBan,
            tp.SoNguoi,
            tp.NgayThue,
            tp.MaThuePhong,
	        p.LoaiPhong,
            DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) AS SoNgay,
            (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) AS TienPhong,
            ISNULL(SUM(dv.ChiPhi), 0) AS TienDichVu,
            CASE 
                WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
                ELSE 0
            END AS PhuThu,
            CASE 
                WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
                ELSE 0
            END AS GiamGiaKhachHang,
            ((DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) 
                + ISNULL(SUM(dv.ChiPhi), 0) 
                + CASE 
                    WHEN tp.SoNguoi > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.1
                    ELSE 0
                  END
                - CASE 
                    WHEN (SELECT COUNT(*) FROM ThuePhong WHERE MaKhachHang = kh.MaKhachHang) > 1 THEN (DATEDIFF(day, TRY_CONVERT(DATE, tp.NgayThue, 103), GETDATE()) * p.GiaCoBan) * 0.05
                    ELSE 0
                  END) AS TongTien
        FROM 
            ThuePhong tp
        JOIN KhachHang kh ON tp.MaKhachHang = kh.MaKhachHang
        JOIN Phong p ON tp.MaPhong = p.MaPhong
        LEFT JOIN DichVu dv ON tp.MaThuePhong = dv.MaThuePhong
        WHERE tp.MaKhachHang =  '" + maKhachHang + "' AND tp.MaThuePhong = '" + maThuePhong + @"'
        GROUP BY
            kh.MaKhachHang, kh.HoTen, p.GiaCoBan, tp.SoNguoi, tp.NgayThue,tp.MaThuePhong,p.LoaiPhong, kh.MaKhachHang
    ";

            DataTable dtKetQua = ketnoi.Execute(query);

            if (dtKetQua.Rows.Count > 0)
            {
                dGVThanhToan.DataSource = dtKetQua; // Hiển thị kết quả trên DataGridView
                DataRow row = dtKetQua.Rows[0];

                // Hiển thị 
                txtTongtien.Text = "" + row["TongTien"].ToString();
                lblKhach.Text = "" + row["HoTen"].ToString();
                lblMaKhach.Text = "" + row["MaKhachHang"].ToString();
                lblPhong.Text = "" + row["LoaiPhong"].ToString();
                lblSoNgayO.Text = "" + row["SoNgay"].ToString();
                lblMaTP.Text = "" + row["MaThuePhong"].ToString();
                lblNgayThanhT.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiemTheoMaKhachHang_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KhachHang JOIN ThuePhong ON KhachHang.MaKhachHang = ThuePhong.MaKhachHang "
                         + "WHERE (KhachHang.SoDienThoai LIKE '%" + cBSDTKH.Text + "%') ";
            txtMaHoaDon.Clear();
            txtHinhThucTT.Clear();
            //AND(ThuePhong.MaThuePhong LIKE '%" + cBMaTP.Text + "%')
            DataTable dt = ketnoi.GetTimKiem(query);
            if (dt.Rows.Count > 0)
            {
                dGVThanhToan.DataSource = dt;
                int index = dGVThanhToan.CurrentRow.Index;
                txtMaKhachHang.Text = dGVThanhToan.Rows[index].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dGVThanhToan.Rows[index].Cells[1].Value.ToString();
                lblMaTP.Text = dGVThanhToan.Rows[index].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVThanhToan.CurrentRow.Index;
            txtMaKhachHang.Text = dGVThanhToan.Rows[index].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dGVThanhToan.Rows[index].Cells[1].Value.ToString();
            lblMaTP.Text = dGVThanhToan.Rows[index].Cells[7].Value.ToString();
            cBSDTKH.Text = dGVThanhToan.Rows[index].Cells[5].Value.ToString();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXemDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon dsHoaDon= new DanhSachHoaDon();
            dsHoaDon.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

            string mahd = txtMaHoaDon.Text;
            string query = "SELECT *"
                           + " FROM HoaDon "
                            + "WHERE MaHoaDon = '"+mahd+"'";
            DataTable dt = ketnoi.Execute(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rpDSHoaDon baocao = new rpDSHoaDon();
            baocao.SetDataSource(dt);

            InHoaDon inhoadon = new InHoaDon();
            inhoadon.crystalReportViewer1.ReportSource = baocao;

            inhoadon.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            string makhachhang = cBSDTKH.Text;
            if (
                    string.IsNullOrWhiteSpace(txtMaHoaDon.Text) ||
                    string.IsNullOrWhiteSpace(txtHinhThucTT.Text) )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string makh = lblMaKhach.Text;
            DateTime ngaythanhtoan = DateTime.Parse(lblNgayThanhT.Text);
            string songayo = lblSoNgayO.Text;
            string phong = lblPhong.Text;
            decimal tongtien = decimal.Parse(txtTongtien.Text);
            string matp = lblMaTP.Text;
            string mahoadon = txtMaHoaDon.Text;
            string hinhthuc = txtHinhThucTT.Text;
            string query = "INSERT INTO HoaDon(MaHoaDon, MaKhachHang,MaThuePhong, Phong, SoNgayO, SoTien, NgayThanhToan, HinhThucThanhToan) " +
                            $"VALUES (@MaHoaDon, @MaKhachHang,@MaThuePhong, @Phong, @SoNgayO, @SoTien, @NgayThanhToan, @HinhThucThanhToan) ";
            
            DataTable dt =  ketnoi.GetThemHoaDon(query, mahoadon, makh, ngaythanhtoan,matp, songayo, phong, hinhthuc, tongtien);
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
