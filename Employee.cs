using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_ex6_7_hugo
{
    public class Employee
    {
        public string? Code {  get; set; }
        public string? FirstName { get; set; }   
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? ReverseName { get; set; }
        public int Age { get; set; }
        public bool Seniority { get; set; }
        public int AnnualSalary { get; set; }   
        public DateTime BirthDate { get; set; }

        public Employee(string code, string firstname, string lastname, string fullname, string reversename, int age, bool seniority, int annualsalary, DateTime birthdate) 
        {
            this.Code = code;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.FullName = firstname +" "+ lastname;
            this.ReverseName = lastname +" "+ firstname;
            this.Age = age;
            this.Seniority = seniority;
            this.AnnualSalary = annualsalary;
            this.BirthDate = birthdate;
        }

        public int CalcAge(DateTime birthDate)
        {
            int age = 0;
            if(birthDate.Year < DateTime.Now.Year)
            {
                age += (DateTime.Now.Year - birthDate.Year); 
            }
            if(birthDate.Month >= DateTime.Now.Month)
            {
                if(DateTime.Now.Day < birthDate.Day) 
                {
                    age--;
                }
            }
            return age;
        }

        public override string ToString()
        {
            return $"\n+----------------------+\n|       EMPLOYEE       |\n+----------------------+\n>codi: {this.Code}\n>nom: {this.FirstName}\n>cognom: {this.LastName}\n>nom complert: {this.FullName}\n>nom revers: {this.ReverseName}\n>edat: {this.Age}\n>seniority: {this.Seniority}\n>Annualitat: {this.AnnualSalary}\n>data de neixement: {this.BirthDate.ToString("dd/MM/yyyy")}";
        }

    }
}
