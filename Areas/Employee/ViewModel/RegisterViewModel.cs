using System.ComponentModel.DataAnnotations;

namespace Cat_Paw_Footprint.Areas.Employee.ViewModel
{
	public class RegisterViewModel
	{
		[Required]
		public string Account { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		public string EmployeeName { get; set; }
		public int RoleId { get; set; }

		public string? ErrorMessage { get; set; }
	}
}
