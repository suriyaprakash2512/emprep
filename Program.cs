// See https://aka.ms/new-console-template for more information
using ConAppTwo;

Console.WriteLine("Hello, World!");


List<Employee> employees = new List<Employee>()
{
    new Employee() { Id=1, Name="sanjay", Designation="developer", DOJ=new DateTime(day:12,month:1, year:2022)},
      new Employee() { Id=2, Name="Aksa", Designation="Tester", DOJ=new DateTime(day:10,month:12, year:2023)},
        new Employee() { Id=3, Name="Ashwin", Designation="developer", DOJ=new DateTime(day:12,month:1, year:2022)},
          new Employee() { Id=4, Name="hari", Designation="manager", DOJ=new DateTime(day:2,month:1, year:2020)},
            new Employee() { Id=5, Name="Anu", Designation="developer", DOJ=new DateTime(day:09,month:10, year:2022)},
              new Employee() { Id=6, Name="deepti", Designation="tester", DOJ=new DateTime(day:18,month:11, year:2022)},
};
Console.WriteLine("Id\t Name\t Designation\t DOJ");
foreach(Employee employee in employees)
{
    Console.WriteLine(employee.Id + "\t \t");
    Console.WriteLine(employee.Name + "\t \t");
    Console.WriteLine(employee.Designation + "\t \t");
    Console.WriteLine(employee.DOJ.ToLongDateString());
    Console.WriteLine("\n");

}

