using MVCDahboard.Data;
using MVCDahboard.Models;

namespace MVCDahboard.Service
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
