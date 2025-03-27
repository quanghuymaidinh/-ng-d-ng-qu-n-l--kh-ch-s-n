namespace QuanLyKhachSan
{
    partial class DatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVDatPhong = new System.Windows.Forms.DataGridView();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaDatPhong = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaDatPhong = new System.Windows.Forms.Label();
            this.gBThongTinDatPhong = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatPhong)).BeginInit();
            this.gBThongTinDatPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVDatPhong
            // 
            this.dGVDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDatPhong.Location = new System.Drawing.Point(28, 441);
            this.dGVDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVDatPhong.Name = "dGVDatPhong";
            this.dGVDatPhong.RowHeadersWidth = 51;
            this.dGVDatPhong.RowTemplate.Height = 24;
            this.dGVDatPhong.Size = new System.Drawing.Size(884, 194);
            this.dGVDatPhong.TabIndex = 3;
            this.dGVDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDatPhong_CellClick);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(332, 305);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(237, 50);
            this.btnDatPhong.TabIndex = 15;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(658, 124);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(172, 32);
            this.dtpNgayDi.TabIndex = 12;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDi.Location = new System.Drawing.Point(569, 131);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(93, 25);
            this.lblNgayDi.TabIndex = 11;
            this.lblNgayDi.Text = "Ngày Đi:";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(658, 62);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(172, 32);
            this.dtpNgayDen.TabIndex = 10;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDen.Location = new System.Drawing.Point(559, 72);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(102, 25);
            this.lblNgayDen.TabIndex = 9;
            this.lblNgayDen.Text = "Ngày đến:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(178, 229);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(217, 38);
            this.txtMaNhanVien.TabIndex = 7;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(178, 171);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(217, 39);
            this.txtMaPhong.TabIndex = 6;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(178, 114);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(217, 42);
            this.txtMaKhachHang.TabIndex = 5;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDatPhong.Location = new System.Drawing.Point(178, 55);
            this.txtMaDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDatPhong.Multiline = true;
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.Size = new System.Drawing.Size(217, 42);
            this.txtMaDatPhong.TabIndex = 4;
            this.txtMaDatPhong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblMaNhanVien.Location = new System.Drawing.Point(24, 232);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(145, 25);
            this.lblMaNhanVien.TabIndex = 3;
            this.lblMaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhong.Location = new System.Drawing.Point(57, 175);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(106, 25);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhachHang.Location = new System.Drawing.Point(19, 124);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(150, 23);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblMaDatPhong
            // 
            this.lblMaDatPhong.AutoSize = true;
            this.lblMaDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDatPhong.ForeColor = System.Drawing.Color.Black;
            this.lblMaDatPhong.Location = new System.Drawing.Point(22, 62);
            this.lblMaDatPhong.Name = "lblMaDatPhong";
            this.lblMaDatPhong.Size = new System.Drawing.Size(144, 25);
            this.lblMaDatPhong.TabIndex = 0;
            this.lblMaDatPhong.Text = "Mã Đặt Phòng:";
            // 
            // gBThongTinDatPhong
            // 
            this.gBThongTinDatPhong.Controls.Add(this.btnDatPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaDatPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaPhong);
            this.gBThongTinDatPhong.Controls.Add(this.txtMaNhanVien);
            this.gBThongTinDatPhong.Controls.Add(this.dtpNgayDi);
            this.gBThongTinDatPhong.Controls.Add(this.lblNgayDi);
            this.gBThongTinDatPhong.Controls.Add(this.dtpNgayDen);
            this.gBThongTinDatPhong.Controls.Add(this.lblNgayDen);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaNhanVien);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaPhong);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaKhachHang);
            this.gBThongTinDatPhong.Controls.Add(this.lblMaDatPhong);
            this.gBThongTinDatPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTinDatPhong.ForeColor = System.Drawing.Color.Navy;
            this.gBThongTinDatPhong.Location = new System.Drawing.Point(28, 39);
            this.gBThongTinDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBThongTinDatPhong.Name = "gBThongTinDatPhong";
            this.gBThongTinDatPhong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBThongTinDatPhong.Size = new System.Drawing.Size(884, 374);
            this.gBThongTinDatPhong.TabIndex = 2;
            this.gBThongTinDatPhong.TabStop = false;
            this.gBThongTinDatPhong.Text = "                           THÔNG TIN ĐẶT PHÒNG";
            this.gBThongTinDatPhong.Enter += new System.EventHandler(this.gBThongTinDatPhong_Enter);
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(945, 650);
            this.Controls.Add(this.dGVDatPhong);
            this.Controls.Add(this.gBThongTinDatPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatPhong";
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatPhong)).EndInit();
            this.gBThongTinDatPhong.ResumeLayout(false);
            this.gBThongTinDatPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDatPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaDatPhong;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaDatPhong;
        private System.Windows.Forms.GroupBox gBThongTinDatPhong;
    }
}