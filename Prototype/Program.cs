using prototype;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var manager = new Manager("Subodh Sharma");
var managerNew = (Manager)manager.Clone();

Console.WriteLine($"Cloned manager name : {managerNew.Name}");

var employee = new Employee("TuTo", manager);
var employeeNew = (Employee)employee.Clone();

Console.WriteLine($" New Emp : {employeeNew.Name} with Clone manager {employeeNew.Manager.Name}");


manager.Name = "Rakesh Sharma";
Console.WriteLine($" New Emp : {employeeNew.Name} with Clone manager {employeeNew.Manager.Name}");

