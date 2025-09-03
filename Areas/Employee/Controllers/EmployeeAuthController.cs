using Cat_Paw_Footprint.Areas.Employee.ViewModel;
using Cat_Paw_Footprint.Data;
using Cat_Paw_Footprint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Scripting;

namespace Cat_Paw_Footprint.Areas.Employee.Controllers
{
	[Area("Employee")]
	public class EmployeeAuthController: Controller//這邊搞登入與註冊功能
	{
		private readonly EmployeeDbContext _context;
		public EmployeeAuthController(EmployeeDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Login()
		{
			var model = new LoginViewModel(); // ✅ 傳入空模型
			return View(model);
		}
		[HttpPost]
		public IActionResult Login([Bind("Account,Password")] LoginViewModel vm)
		
		{
			System.Diagnostics.Debug.WriteLine("🧪 進入 Login POST");
			System.Diagnostics.Debug.WriteLine($"帳號:{vm.Account}");
			if (!ModelState.IsValid)
			{
				foreach (var kvp in ModelState)
				{
					var key = kvp.Key;
					var errors = kvp.Value.Errors;
					foreach (var error in errors)
					{
						Console.WriteLine($"欄位 {key} 錯誤：{error.ErrorMessage}");
					}
				}

				return View(vm);
			}
			// ❗ 改成只用帳號找，先不要比對密碼
			var emp = _context.Employees.FirstOrDefault(e => e.Account == vm.Account);

			// ❗ 沒找到帳號
			if (emp == null)
			{
				Console.WriteLine("登入失敗：帳號不存在 " + vm.Account);
				vm.ErrorMessage = "帳號不存在";
				return View(vm);
			}

			// ❗ 密碼比對失敗
			if (!BCrypt.Net.BCrypt.Verify(vm.Password, emp.Password))
			{
				vm.ErrorMessage = "密碼錯誤";
				return View(vm);
			}
			var profile = _context.EmployeeProfiles
			.FirstOrDefault(p => p.EmployeeId == emp.EmployeeId);

			string empName = profile?.EmployeeName ?? "未填寫";


			HttpContext.Session.SetString("EmpId", emp.EmployeeId.ToString());
			HttpContext.Session.SetString("EmpName", empName);
			return RedirectToAction("Dashboard", "Home");
		}

		[HttpGet]
		public IActionResult Register()
		{
			var roles = _context.EmployeeRoles
				.Select(r => new { r.RoleId, r.RoleName })
				.ToList();

			ViewBag.RoleList = new SelectList(roles, "RoleId", "RoleName");

			return View();
		}
		[HttpPost]
		public IActionResult Register(RegisterViewModel model)
		{
			if(!ModelState.IsValid)
			{
				return View(model);
			}
			if(_context.Employees.Any(e=>e.Account==model.Account))
			{
				model.ErrorMessage="此帳號已被註冊";
				return View(model);
			}
			var emp = new Cat_Paw_Footprint.Models.Employee//註冊員工帳號
			{
				Account=model.Account,
				Password=BCrypt.Net.BCrypt.HashPassword(model.Password),
				RoleId=model.RoleId,
				CreateDate=DateTime.Now,
				Status= true
			};
			_context.Employees.Add(emp);
			_context.SaveChanges();

			var profile = new EmployeeProfile//註冊之後產生基本員工個資表，剩下給員工自己寫
			{
				EmployeeId=emp.EmployeeId,
				EmployeeName=model.EmployeeName,
			};

			_context.EmployeeProfiles.Add(profile);
			_context.SaveChanges();


			return RedirectToAction("Login");
		}

	}
}
