using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Lab1.Employee;
using static Lab1.Person;

namespace Lab1
{
    internal class EmployeeCollection
    {
        public delegate void EmployeeListHandler(object source, EmployeeListHandlerEventArgs args);
        public event EmployeeListHandler EmployeeAdded;
        public event EmployeeListHandler EmployeeReplaced;
        public string NameOfCollection { get; set; }
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public EmployeeCollection()
        {
            Employees.Add(new Employee());
        }
        public EmployeeCollection(Employee employee)
        {
            Employees.Add(employee);
        }
        public Employee this[int index]
        {
            get
            {
                if(index >= 0 &&  index < Employees.Count)
                {
                    return Employees[index];
                }
                else
                {
                    return Employees[0];
                }
            }
            set
            {
                if (index >= 0 && index < Employees.Count)
                {
                   Employees[index] = value;
                    if(EmployeeReplaced != null)
                    {
                        EmployeeReplaced(this, new EmployeeListHandlerEventArgs(NameOfCollection, "Replaced the element", index));
                    }
                }
            }
        }
        public bool Replace(int j, Employee emp)
        {
            if (Employees.Contains(Employees[j]))
            {
                Employees[j] = emp;
                if(EmployeeReplaced != null)
                {
                    EmployeeReplaced(this, new EmployeeListHandlerEventArgs(NameOfCollection, "Replaced the element", j));
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void AddDefaults()
        {
            Employees.Add(new Employee());
            if(EmployeeAdded != null)
            {
                EmployeeAdded(this, new EmployeeListHandlerEventArgs(NameOfCollection, "Added an element", Employees.Count - 1));
            }
        }
        public void AddEmployees(params Employee[] employees) 
        {
            for(int i = 0; i < employees.Length; i++)
            {
                Employees.Add(employees[i]);
                if (EmployeeAdded != null)
                {
                    EmployeeAdded(this, new EmployeeListHandlerEventArgs(NameOfCollection, "Added an element", Employees.Count - 1));
                }
            }
        }
        public override string ToString()
        {
            return $"{string.Join(";", Employees)}";
        }
        public string ToShortString()
        {
            string result = "";
            foreach (var employee in Employees)
            {
                result += $"{employee.PersonData}, {employee.Position}, {employee.WorkTime}, Salary: {employee.Salary}, NumberOfDiplomas: {employee.Diplomas.Count}, NumberOfWorks: {employee.Experiences.Count}";
            }
            return result;
        }
        public void SortBySurname()
        {
            Employees.Sort();
        }
        public void SortByDate()
        {
            Employees.Sort(new Person());
        }
        public void SortBySalary()
        {
            Employees.Sort(new SalaryComparer());
        }
    }
}
