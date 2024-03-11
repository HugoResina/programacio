using employees_ex6_7_hugo;
using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        //employees objs
        Employee employee = new Employee("1234", "Pepe", "Garcia", "", "", 48, true, 120000, new DateTime(1975, 04, 15));
        SalesEmployee salesemployee = new SalesEmployee(250, "4321", "Susanna", "Perez", "", "", 30, false, 90000, new DateTime(1993, 07, 22));
        Employee employee2 = new Employee("1423", "Maria", "Blanco", "", "", 58, true, 150000, new DateTime(1965, 04, 15));
        SalesEmployee salesemployee2 = new SalesEmployee(150, "2321", "Pere", "Català", "", "", 22, false, 55000, new DateTime(2001, 07, 22));
        Console.WriteLine(employee.ToString());
        Console.WriteLine("edad calculada: " + employee.CalcAge(employee.BirthDate));
        Console.WriteLine(salesemployee.ToString());
        Console.WriteLine("edad calculada: " + salesemployee.CalcAge(salesemployee.BirthDate));
        Console.WriteLine(salesemployee2.ToString());
        Console.WriteLine("edad calculada: " + salesemployee2.CalcAge(salesemployee2.BirthDate));
        Console.WriteLine(employee2.ToString());
        Console.WriteLine("edad calculada: " + employee2.CalcAge(employee2.BirthDate));

        //dicc name/salary
        Dictionary<string, int> employeedicc = new Dictionary<string, int>();
        employeedicc.Add(employee.FirstName, employee.AnnualSalary);
        employeedicc.Add(salesemployee.FirstName, salesemployee.AnnualSalary);
        employeedicc.Add(employee2.FirstName, employee2.AnnualSalary);
        employeedicc.Add(salesemployee2.FirstName, salesemployee2.AnnualSalary);
        Console.WriteLine();
        Console.WriteLine("empleats i sou anual:");
        Console.WriteLine();
        /*foreach (var item in employeedicc)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine();*/
        foreach (var item in employeedicc)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("\nelimina numeros de una llista segons una comprovacio\n");

        //elimina nums
        List<int> nums = new List<int>();
        nums.Add(3);
        nums.Add(12);
        nums.Add(4);
        nums.Add(65);
        nums.Add(43);
        nums.Add(23);
        nums.Add(2);
        nums.Add(78);
        nums.Add(12);
        nums.Add(35);
        List<int> purgedNums = new List<int>();
        foreach(var item in nums)
        {
            if((item > 25))
            {
                purgedNums.Add(item);
            }
        }
        foreach (var item in purgedNums)
        {
            nums.Remove(item);
        }
        foreach(var item in nums)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}