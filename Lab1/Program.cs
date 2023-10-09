using Lab1;
using System;
using System.Reflection;

EmployeeCollection employees1 = new EmployeeCollection();
EmployeeCollection employees2 = new EmployeeCollection();
Listener listener1 = new Listener();
Listener listener2 = new Listener();
employees1.NameOfCollection = "Employees1";
employees2.NameOfCollection = "Employees2";
employees1.EmployeeAdded += listener1.HandleEmployee;
employees1.EmployeeReplaced += listener1.HandleEmployee;

employees1.EmployeeAdded += listener2.HandleEmployee;
employees2.EmployeeAdded += listener2.HandleEmployee;

employees1.AddEmployees(new Employee(), new Employee(), new Employee());
employees2.AddEmployees(new Employee());
employees1.Replace(2, new Employee(new Person("Roman", "Nahorniy", DateTime.Now), "Middle", TimeWork.FullTime, 5));
employees2[0] = new Employee(new Person("Roman", "Nahorniy", DateTime.Now), "Middle", TimeWork.FullTime, 5);

Console.WriteLine("Listener1 \n" + listener1.ToString());
Console.WriteLine("Listener2 \n" + listener2.ToString());
