using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_ex6_7_hugo
{
    internal class SalesEmployee : Employee
    {
        public int Commission;

        public SalesEmployee(int commission, string code, string firstname, string lastname, string fullname, string reversename, int age, bool seniority, int annualsalary, DateTime birthdate) : base( code,  firstname,  lastname,  fullname,  reversename,  age,  seniority,  annualsalary, birthdate)
        {
            this.Commission = commission;
        }

        public override string ToString()
        {
            return $"\n+----------------------+\n|    SALES EMPLOYEE    |\n+----------------------+\n>codi: {this.Code}\n>nom: {this.FirstName}\n>cognom: {this.LastName}\n>nom complert: {this.FullName}\n>nom revers: {this.ReverseName}\n>edat: {this.Age}\n>seniority: {this.Seniority}\n>Annualitat: {this.AnnualSalary}\n>data de neixement: {this.BirthDate.ToString("dd/MM/yyyy")}\n>Commisio: {this.Commission}";
        }
    }
}
