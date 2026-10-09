namespace QuanLySinhVienCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(596, 38);
            label1.TabIndex = 0;
            label1.Text = "QUAN LY SINH VIEN - EF CORE (CRUD FULL)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 1;
            label2.Text = "Ho Ten:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(420, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 2;
            label3.Text = "Diem: ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(88, 81);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(311, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(489, 85);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(141, 27);
            txtDiem.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 137);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(175, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(296, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(420, 137);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(144, 29);
            btnTaiLai.TabIndex = 8;
            btnTaiLai.Text = "Tai Lai Danh Sach";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(595, 137);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(144, 29);
            btnLocDat.TabIndex = 9;
            btnLocDat.Text = "Loc SV dat (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(22, 185);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(743, 198);
            dgvSinhVien.TabIndex = 10;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lblTrangThai.ForeColor = Color.IndianRed;
            lblTrangThai.Location = new Point(34, 407);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(48, 20);
            lblTrangThai.TabIndex = 11;
            lblTrangThai.Text = "NULL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quan Ly Sinh Vien ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
    }
}
