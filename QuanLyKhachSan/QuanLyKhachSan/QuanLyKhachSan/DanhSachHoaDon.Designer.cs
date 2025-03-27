namespace QuanLyKhachSan
{
    partial class DanhSachHoaDon
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
            this.dGVDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.lblDanhSachHoaDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDanhSachHoaDon
            // 
            this.dGVDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachHoaDon.Location = new System.Drawing.Point(44, 140);
            this.dGVDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVDanhSachHoaDon.Name = "dGVDanhSachHoaDon";
            this.dGVDanhSachHoaDon.RowHeadersWidth = 51;
            this.dGVDanhSachHoaDon.RowTemplate.Height = 24;
            this.dGVDanhSachHoaDon.Size = new System.Drawing.Size(810, 358);
            this.dGVDanhSachHoaDon.TabIndex = 0;
            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.AutoSize = true;
            this.lblDanhSachHoaDon.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDanhSachHoaDon.Location = new System.Drawing.Point(235, 42);
            this.lblDanhSachHoaDon.Name = "lblDanhSachHoaDon";
            this.lblDanhSachHoaDon.Size = new System.Drawing.Size(457, 45);
            this.lblDanhSachHoaDon.TabIndex = 1;
            this.lblDanhSachHoaDon.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.lblDanhSachHoaDon);
            this.Controls.Add(this.dGVDanhSachHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachHoaDon";
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.DanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDanhSachHoaDon;
        private System.Windows.Forms.Label lblDanhSachHoaDon;
    }
}