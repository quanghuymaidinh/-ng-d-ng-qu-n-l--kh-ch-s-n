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
    public partial class DanhSachHoaDon : Form
    {
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();   
        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            string query = "select* from HoaDon";
            dGVDanhSachHoaDon.DataSource = ketnoi.Execute(query);
        }
    }
}
