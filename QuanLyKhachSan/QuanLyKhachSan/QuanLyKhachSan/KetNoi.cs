using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace QuanLyKhachSan
{
    internal class KetNoi
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public KetNoi()
        {
            string str = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString;
            //string str = "Data Source=PHONGDANG-LAPTO\\PHONGDANG;Initial Catalog=QLDiemSV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
        }

        public void openConnection()
        {
            if (ConnectionState.Closed == conn.State)
            {
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                    }

                }

            }
        }
        public void closeConnection()
        {
            if (ConnectionState.Open == conn.State)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                }
            }
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            openConnection();

            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            openConnection();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }

        }
        public DataTable Getlogin(string query, string username, string password)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetThem(string query, string maKhachHang, string hoTen, string phai, string ngaySinh, string diaChi, string soDienThoai, string cmND)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cmND);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetSua(string query, string maKhachHang, string hoTen, string phai, string ngaySinh, string diaChi, string soDienThoai, string cmND)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@CMND_Passport", cmND);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable GetTimKiem(string query)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm, vui lòng thử lại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetTinhTien(string query)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tiền, vui lòng thử lại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetDatPhong(string query, string maDatPhong, string maKhachHang,
        string maPhong,
        string maNhanVien,
        string ngayDen,
        string ngayDi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDatPhong", maDatPhong);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@NgayDen", ngayDen);
                    cmd.Parameters.AddWithValue("@NgayDi", ngayDi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public DataTable GetThemHoaDon(string query, string mahoadon, string makh, DateTime ngaythanhtoan, string matp, string songayo, string phong, string hinhthuc, decimal tongtien)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoaDon", mahoadon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                    cmd.Parameters.AddWithValue("@Phong", phong);
                    cmd.Parameters.AddWithValue("@MaThuePhong", matp);
                    cmd.Parameters.AddWithValue("@SoNgayO", songayo);
                    cmd.Parameters.AddWithValue("@SoTien", tongtien);
                    cmd.Parameters.AddWithValue("@NgayThanhToan", ngaythanhtoan);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhthuc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn, vui lòng thử lại: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public DataTable ThemDichVu(string query, string madichvu, string mathuephong, string tendichvu, Decimal chiphi)
        {
            DataTable dt = new DataTable();
            openConnection();
            try
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaDichVu", madichvu);
                    cmd.Parameters.AddWithValue("@MaThuePhong", mathuephong);
                    cmd.Parameters.AddWithValue("@TenDichVu", tendichvu);
                    cmd.Parameters.AddWithValue("@ChiPhi", chiphi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

    }
   
}