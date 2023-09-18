using Lab3;
using System;
using System.Reflection;
//1.Створити об'єкт типу EmployeeCollection. Додати до колекції кілька різних елементів типу Employee і вивести об'єкт EmployeeCollection.
EmployeeCollection employeeCollection = new EmployeeCollection(new Employee(new Person("Ivan", "B", DateTime.Parse("03.03.2005")), "0", TimeWork.FullTime, 200));
employeeCollection.AddEmployees(new Employee(new Person("Petro", "C", DateTime.Parse("01.01.2005")), "0", TimeWork.FullTime, 100), new Employee(new Person("Roman", "A", DateTime.Parse("02.02.2005")), "0", TimeWork.FullTime, 300));
Console.WriteLine(employeeCollection);
Console.WriteLine("=======================================");
//2.Для створеного об'єкта EmployeeCollection викликати методи, які виконують сортування списку List<Employee> за різними критеріями, і після кожного сортування вивести дані об'єкта. Виконати сортування
//за  прізвищем співробітника
employeeCollection.SortBySurname();
Console.WriteLine(employeeCollection);
Console.WriteLine("=======================================");
//за датою народження
employeeCollection.SortByDate();
Console.WriteLine(employeeCollection);
Console.WriteLine("=======================================");
//за окладом
employeeCollection.SortBySalary();
Console.WriteLine(employeeCollection);
Console.WriteLine("=======================================");
//3.Створити об'єкт типу TestCollections. Викликати метод для пошуку в колекціях першого, центрального, останнього і елемента, що не входить в колекції. Вивести  значення  часу  пошуку  для  всіх  чотирьох  випадків  з поясненнями  про  те,  для  якої  колекції  і  для  якого  елементу  отримано значення.
int number = 10000;
TestCollections testCollections = new TestCollections(number);
string middleIndex = (number / 2).ToString();
string lastIndex = (number - 1).ToString();
string[] indices = { "0", middleIndex, lastIndex, number.ToString() };

foreach(string index in indices)
{
    Person testPerson = new Person(index, index, new DateTime());
    Employee testEmployee = new Employee(testPerson, "Beginner", TimeWork.Free, 100);
    Console.WriteLine("Index: " + index);
    Console.WriteLine("=======================================");
    Console.WriteLine("Search Person: " + testCollections.SearchPerson(testPerson).ToString());
    Console.WriteLine();
    Console.WriteLine("Search String: " + testCollections.SearchString(testEmployee.ToString()).ToString());
    Console.WriteLine();
    Console.WriteLine("SearchByKeyInDictionary1: " + testCollections.SearchByKeyInDictionary1(testPerson).ToString());
    Console.WriteLine();
    Console.WriteLine("SearchByKeyInDictionary2: " + testCollections.SearchByKeyInDictionary2(testEmployee.ToString()).ToString());
    Console.WriteLine();
    Console.WriteLine("SearchByValueInDictionary1: " + testCollections.SearchByValueInDictionary1(testEmployee).ToString());
    Console.WriteLine();
    Console.WriteLine("SearchByValueInDictionary2: " + testCollections.SearchByValueInDictionary2(testEmployee).ToString());
    Console.WriteLine();
    Console.WriteLine("=======================================");
}


