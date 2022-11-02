using CashCrusaders_2_Otokiti.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_2_Otokiti.App
{
    public class HelpCommandHandler : ICommandHandler
    {
        private readonly IEnumerable<Employee> _employees;

        public HelpCommandHandler(IEnumerable<Employee> employee)
        {
            _employees = employee;
        }

        public void HandleCommand()
        {
            Console.WriteLine("> List of all employees on the system: ");
            Console.WriteLine();

            foreach (var employee in _employees)
            {
                Console.WriteLine($"> {employee.Name}");
            }
            Console.WriteLine();
        }
    }
}
