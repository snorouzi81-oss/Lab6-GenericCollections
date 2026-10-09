using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_GenericCollections
{
    internal class Employee
    {
        public int Id { set; get; } = 1;
        public string Name { set; get; } = "Loo";
        public string Gender { set; get; } = "Male";
        public decimal Salary { set; get; } = 25000;

        public Employee()
        {
                
        }
        public Employee(int id,string name, string gender,decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
