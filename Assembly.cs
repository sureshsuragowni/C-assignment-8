using System;
using System.Reflection;



namespace AssemblyEmployee
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmployeeId = EmpId;
            this.EmployeeName = EmpName;
            this.EmployeeSalary = EmpSalary;
        }
        public void empDetails()
        {
            Console.WriteLine("Employee Id :" + EmployeeId);
            Console.WriteLine("Employee name :" + EmployeeName);
            Console.WriteLine("Employee Salary :" + EmployeeSalary);
        }
    }
    class Assembly1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(23, "Suresh Gowd", 56000);

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            emp.empDetails();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] mi = item.GetMethods();



                foreach (var method in mi)
                {
                    Console.WriteLine(method.Name);



                }
            }
            Console.ReadLine();
        }
    }
}
