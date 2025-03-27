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
    public partial class DoanhThu : Form
    {
        KetNoi ketnoi = new KetNoi();
        string quyenHan = ""; // Biến lưu trữ quyền hạn của người dùng

        public DoanhThu(string quyenHan)
        {
            InitializeComponent();
            this.quyenHan = quyenHan; // Lưu trữ quyền hạn của người dùng khi khởi tạo form
        }

        void loaddata()
        {
            string qr = "select * from HoaDon";
            dataGridView1.DataSource = ketnoi.Execute(qr);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTKthang_Click(object sender, EventArgs e)
        {
            if (quyenHan != "admin")
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                return;
            }

            string thang = txtThang.Text;
            string nam = txtNam.Text;
            string query = " SELECT YEAR(NgayThanhToan) AS Năm,MONTH(TRY_CONVERT(DATE, NgayThanhToan)) as Tháng ,SUM(SoTien) AS TongDoanhThu "
                            + "FROM HoaDon "
                            + " WHERE MONTH(TRY_CONVERT(DATE, NgayThanhToan)) ='" + thang + "' AND YEAR(NgayThanhToan)= '" + nam + "'"
                            + " GROUP BY YEAR(NgayThanhToan),MONTH(TRY_CONVERT(DATE, NgayThanhToan))";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void btnTKnam_Click(object sender, EventArgs e)
        {
            if (quyenHan != "admin")
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
                return;
            }

            string nam = txtNam.Text;
            string query = " SELECT YEAR(NgayThanhToan) AS Năm,SUM(SoTien) AS TongDoanhThu "
                            + "FROM HoaDon "
                            + " WHERE YEAR(NgayThanhToan)= '" + nam + "'"
                            + " GROUP BY YEAR(NgayThanhToan),MONTH(NgayThanhToan)";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            loaddata();

            // Kiểm tra quyền hạn và ẩn các chức năng không phù hợp
            if (quyenHan != "admin")
            {
                btnTKthang.Enabled = false;
                btnTKnam.Enabled = false;
            }
        }
    }
}
