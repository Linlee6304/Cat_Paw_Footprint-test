using Cat_Paw_Footprint.Models;
using Microsoft.EntityFrameworkCore;
namespace Cat_Paw_Footprint.Data
{
	public class EmployeeDbContext: DbContext
	{
		public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
			: base(options)
		{
		}
		public DbSet<Models.Employee> Employees { get; set; } 
		public DbSet<Models.EmployeeRole> EmployeeRoles { get; set; } 
		public DbSet<Models.EmployeeProfile> EmployeeProfiles { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>(entity =>
			{
				entity.HasKey(e => e.EmployeeId);
			});

			modelBuilder.Entity<EmployeeRole>(entity =>
			{
				entity.HasKey(e => e.RoleId);
			});
			modelBuilder.Entity<EmployeeProfile>(entity =>
			{
				entity.HasKey(e => e.ProfileId);
			});
		}

	}
}

