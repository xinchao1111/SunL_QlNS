﻿namespace QuanLyNhanSu.CT
{
    partial class SuaTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbMNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQH = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dg = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(623, 59);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(134, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(398, 18);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(190, 20);
            this.txtMK.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quyền Hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(91, 18);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(190, 20);
            this.txtTK.TabIndex = 15;
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Location = new System.Drawing.Point(122, 64);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(56, 13);
            this.lbMNV.TabIndex = 11;
            this.lbMNV.Text = "Tài Khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tài Khoản";
            // 
            // cbQH
            // 
            this.cbQH.FormattingEnabled = true;
            this.cbQH.Items.AddRange(new object[] {
            "Super Admin",
            "Admin",
            "User"});
            this.cbQH.Location = new System.Drawing.Point(688, 18);
            this.cbQH.Name = "cbQH";
            this.cbQH.Size = new System.Drawing.Size(190, 21);
            this.cbQH.TabIndex = 8;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(468, 59);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(134, 23);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.cbQH);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbMNV);
            this.panel1.Location = new System.Drawing.Point(50, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 250);
            this.panel1.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.TenDangNhap,
            this.MatKhau,
            this.QuyenHan});
            this.dg.Location = new System.Drawing.Point(0, 97);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(890, 150);
            this.dg.TabIndex = 16;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhanVien.DataPropertyName = "TenNV";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 150;
            // 
            // QuyenHan
            // 
            this.QuyenHan.DataPropertyName = "TenQuyenHan";
            this.QuyenHan.HeaderText = "Quyền Hạn";
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.ReadOnly = true;
            this.QuyenHan.Width = 150;
            // 
            // SuaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SuaTK";
            this.Size = new System.Drawing.Size(990, 502);
            this.Load += new System.EventHandler(this.SuaTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQH;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenHan;

    }
}
