using CashCrusaders_2_Otokiti.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_2_Otokiti.App
{
    public class CommandHandler : ICommandHandler
    {
        private readonly IEnumerable<Employee> _employees;
        private readonly string _line;

        public CommandHandler(IEnumerable<Employee> employee, string line)
        {
            _employees = employee;
            _line = line;
        }

        public void HandleCommand()
        {
            var foundEmployee = _employees.SingleOrDefault(x => x.Name.Contains(_line, StringComparison.OrdinalIgnoreCase));
            if (foundEmployee != null)
            {
                var foundEmployeeId = foundEmployee.PositionId;

                var sortedEmployees = _employees.OrderBy(x => x.PositionId).Where(x => x.PositionId > foundEmployeeId).ToList();

                if (sortedEmployees.Count == 1)
                {
                    var employee = sortedEmployees.Single();
                    Console.WriteLine($"> Employee {employee.Name} reports to {foundEmployee.Name}. ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"> List of employees reporting to {foundEmployee.Name}: ");
                    Console.WriteLine();

                    foreach (var employee in sortedEmployees)
                    {
                        Console.WriteLine($"> {employee.Name}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"> No employee with that name found.");
                Console.WriteLine();
            }
        }
    }
}
