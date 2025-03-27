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
    public partial class Main : Form
    {
        private string quyenHan;
        KetNoi ketNoi = new KetNoi();
        public Main()
        {
            InitializeComponent();
            this.quyenHan = quyenHan;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainEnabled();
            if (quyenHan != "admin")
            {
                dsDoiMatKhau.Enabled = false;
            }
        }

        private void dsDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong fmDP = new DatPhong();
            fmDP.ShowDialog();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuePhong fmTP = new ThuePhong();
            fmTP.ShowDialog();
        }
        private void MainEnabled()
        {
            mHeThong.Enabled = true;
            dsHeThong.Enabled = true;
            dsQuanLiKhachHang.Enabled = true;
            dsQuanLyPhong.Enabled = true;
            dsThongKe.Enabled = true;
           
        }
        private void MainOut()
        {
            mHeThong.Enabled = false;
            dsHeThong.Enabled = false;
            dsQuanLiKhachHang.Enabled = false;
            dsQuanLyPhong.Enabled = false;
            dsThongKe.Enabled = false;

        }
        private void dsDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();
                Login login = new Login();
                login.ShowDialog();
                
            }
            
        }

        private void dsDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (quyenHan == "admin")
            {
                Doimatkhau fmDMK = new Doimatkhau(quyenHan); // Truyền quyền hạn vào form đổi mật khẩu
                fmDMK.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền đổi mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dsThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dsThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang fmTTKH = new ThongTinKhachHang();
            fmTTKH.ShowDialog();
        }

        private void dsThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan fmTT = new ThanhToan();
            fmTT.ShowDialog();
        }

        private void dsPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong fmQLP = new QuanLyPhong();
            fmQLP.ShowDialog();
        }

        private void dsHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();   
            hoadon.ShowDialog();
        }

        private void DichVu_Click(object sender, EventArgs e)
        {
            DichVu dichvu = new DichVu();
            dichvu.ShowDialog();
        }

        private void dsDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon();
            danhSachHoaDon.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu doanhthu = new DoanhThu("admin"); 
            doanhthu.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
        }
    }
}
