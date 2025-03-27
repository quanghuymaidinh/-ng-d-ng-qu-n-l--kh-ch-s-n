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
    public partial class Doimatkhau : Form
    {
        KetNoi ketnoi = new KetNoi();
        private string quyenHan; // Biến lưu trữ quyền hạn của người dùng

        public Doimatkhau(string quyenHan)
        {
            InitializeComponent();
            this.quyenHan = quyenHan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string qr = "Select count (*) From DANGNHAP Where ID= N'" + txtTendangnhap.Text + "' and Pass= N'" + txtMatkhaucu.Text + "'";
            DataTable dt = ketnoi.Execute(qr);
            errorProvider1.Clear();

            if (dt.Rows[0][0].ToString() == "1")
            {
                // Kiểm tra xem quyền hạn có phải là admin không
                if (quyenHan == "admin")
                {
                    if (!string.IsNullOrEmpty(txtMatkhaumoi.Text) && txtMatkhaumoi.Text == txtNhaplaimatkhaumoi.Text)
                    {
                        string query = "Update DANGNHAP set Pass = N'" + txtMatkhaumoi.Text + "' Where Id= N'" + txtTendangnhap.Text + "' and Pass = N'" + txtMatkhaucu.Text + "'";
                        ketnoi.Execute(query);
                        MessageBox.Show("Thành công", "Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                    if (string.IsNullOrEmpty(txtMatkhaumoi.Text))
                    {
                        errorProvider1.SetError(txtMatkhaumoi, "Bạn chưa điền mật khẩu !");
                    }
                    if (string.IsNullOrEmpty(txtNhaplaimatkhaumoi.Text))
                        errorProvider1.SetError(txtNhaplaimatkhaumoi, "Bạn chưa điền mật khẩu !");
                    else if (txtMatkhaumoi.Text != txtNhaplaimatkhaumoi.Text)
                        errorProvider1.SetError(txtNhaplaimatkhaumoi, "Mật khẩu mới chưa đúng !");
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền đổi mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(txtTendangnhap, "Tên đăng nhập sai !");
                errorProvider1.SetError(txtMatkhaucu, "Mật khẩu cũ sai !");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}