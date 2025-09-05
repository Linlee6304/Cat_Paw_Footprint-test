using Cat_Paw_Footprint.Models;
using Microsoft.EntityFrameworkCore;
namespace Cat_Paw_Footprint.Data
{
	public class EmployeeDbContext : DbContext
	{
		public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
			: base(options)
		{
		}
		public DbSet<Models.Employees> Employees { get; set; }
		public DbSet<Models.EmployeeRoles> EmployeeRoles { get; set; }
		public DbSet<Models.EmployeeProfile> EmployeeProfile { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employees>(entity =>
			{
				entity.HasKey(e => e.EmployeeID);

				// 多對一：Employee -> Role
				entity.HasOne(e => e.Role)
					  .WithMany(r => r.Employees)
					  .HasForeignKey(e => e.RoleID)
					  .OnDelete(DeleteBehavior.Restrict);

				// 一對一：Employee -> Profile（設定在這一邊就夠了）
				entity.HasOne(e => e.EmployeeProfile)
					  .WithOne(p => p.Employee)
					  .HasForeignKey<EmployeeProfile>(p => p.EmployeeID)
					  .OnDelete(DeleteBehavior.Cascade);

				entity.HasIndex(e => e.RoleID); // 查詢常用可建索引
			});

			modelBuilder.Entity<EmployeeRoles>(entity =>
			{
				entity.HasKey(e => e.RoleID);
			});
			modelBuilder.Entity<EmployeeProfile>(entity =>
			{
				entity.HasKey(e => e.EmployeeProfileID);

				entity.HasIndex(p => p.EmployeeID).IsUnique(); // 1 對 1 的唯一鍵
			});
			
		}

	}
}

