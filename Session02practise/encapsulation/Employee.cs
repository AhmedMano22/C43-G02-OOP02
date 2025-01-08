using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02practise.encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int Id;
        public string? Name;
        public decimal Salary;


        #endregion

        #region Counstructors
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"ID :{Id}\nName : {Name}\nSalary : {Salary}";
        }
        #endregion
    }
}
