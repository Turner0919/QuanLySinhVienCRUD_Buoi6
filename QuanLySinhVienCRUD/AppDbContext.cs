using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVienCRUD
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sửa lại Server cho đúng máy của bạn trước khi chạy thử
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-R5OJKQCA\\SQLEXPRESS;" +
                "Database=QuanLySinhVien234;" +
                "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
