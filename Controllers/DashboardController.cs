using Microsoft.AspNetCore.Mvc;
using MVCDahboard.Models;
using MVCDahboard.Service;

namespace MVCDahboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly EmployeeService _employeeService;
        public DashboardController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            // Fetch data and pass it to the view
            var viewModel = new DashboardViewModel
            {
                Widget1Data = GetWidget1Data(),
                Widget2Data = GetWidget2Data(),
                 EmployeeData = _employeeService.GetAllEmployees()
            };
            return View(viewModel);
        }

        private List<string> GetWidget1Data()
        {
            // Fetch data for widget 1
            return new List<string> { "Data1", "Data2", "Data3" };
        }

        private List<int> GetWidget2Data()
        {
            // Fetch data for widget 2
            return new List<int> { 10, 20, 30 };
        }
    }
}
