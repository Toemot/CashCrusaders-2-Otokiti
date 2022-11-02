using CashCrusaders_2_Otokiti.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_2_Otokiti.DataAccess.Data
{
    public class DataProvider
    {
        public IEnumerable<Employee> LoadEmployees()
        {
            yield return new Employee { Id = 3, Name = "Stanton", PositionId = 102 };
            yield return new Employee { Id = 10, Name = "Megan", PositionId = 106 };
            yield return new Employee { Id = 4, Name = "Andries", PositionId = 102 };
            yield return new Employee { Id = 1, Name = "Jason", PositionId = 100 };
            yield return new Employee { Id = 2, Name = "Jody", PositionId = 101 };
            yield return new Employee { Id = 8, Name = "Athi", PositionId = 104 };
            yield return new Employee { Id = 9, Name = "Bule", PositionId = 105 };
            yield return new Employee { Id = 5, Name = "Roscoe", PositionId = 102 };
            yield return new Employee { Id = 6, Name = "Ian", PositionId = 103 };
            yield return new Employee { Id = 7, Name = "Bradley", PositionId = 103 };
        }
    }
}
