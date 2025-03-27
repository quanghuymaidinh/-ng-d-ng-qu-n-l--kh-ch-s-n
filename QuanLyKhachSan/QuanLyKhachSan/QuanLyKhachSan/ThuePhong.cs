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
    public partial class ThuePhong : Form
    {
        KetNoi ketNoi = new KetNoi();   
        public ThuePhong()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            string str = "select * from ThuePhong";
            dGVThuePhong.DataSource = ketNoi.Execute(str);
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {

        }
    }
}
