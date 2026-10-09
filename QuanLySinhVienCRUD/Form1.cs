using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVienCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Sẵn sàng. Hãy chạy Migration trước khi dùng (xem README.md).";
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> danhSach = await context.Students.ToListAsync();
                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = danhSach;
                    lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
                    lblTrangThai.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Students.Add(new Student { Name = txtHoTen.Text, Diem = diem });
                    await context.SaveChangesAsync();
                }

                lblTrangThai.Text = "Đã thêm sinh viên mới!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diemMoi))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students.FindAsync(svDangChon.Id);
                    if (sv != null)
                    {
                        sv.Name = txtHoTen.Text;
                        sv.Diem = diemMoi;
                        await context.SaveChangesAsync();
                    }
                }

                lblTrangThai.Text = "Đã cập nhật thông tin!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{svDangChon.Name}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students.FindAsync(svDangChon.Id);
                    if (sv != null)
                    {
                        context.Students.Remove(sv);
                        await context.SaveChangesAsync();
                    }
                }

                lblTrangThai.Text = "Đã xóa sinh viên!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> ketQua = await context.Students
                        .Where(sv => sv.Diem >= 5)
                        .OrderByDescending(sv => sv.Diem)
                        .ToListAsync();

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = ketQua;
                    lblTrangThai.Text = $"Tìm thấy {ketQua.Count} sinh viên đạt (>=5).";
                    lblTrangThai.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }
    }
}
