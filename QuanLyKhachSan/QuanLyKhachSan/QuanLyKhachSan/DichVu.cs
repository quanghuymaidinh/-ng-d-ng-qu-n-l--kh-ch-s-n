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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        KetNoi ketnoi = new KetNoi();
        void loaddata()
        {
            string query = " select* from DichVu";
            dGVDichVu.DataSource = ketnoi.Execute(query);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string madichvu = txtMaDichVu.Text; 
            string mathuephong = txtMaThuePhong.Text;
            string tendichvu= txtTienDichVu.Text;
            Decimal chiphi = Decimal.Parse(txtChiPhi.Text);

            string query = "INSERT INTO DichVu (MaDichVu, MaThuePhong, TenDichVu, ChiPhi) " 
                            + "VALUES (@MaDichVu, @MaThuePhong, @TenDichVu, @ChiPhi)";
            ketnoi.ThemDichVu(query,madichvu,mathuephong,tendichvu,chiphi);
            loaddata();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
