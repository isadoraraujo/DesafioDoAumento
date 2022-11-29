using System;

namespace DesafioDoAumento.Class
{
    public class Employee : IEmployee
    {
        public Employee() { }

        public Employee(string Name, string Occupation, double Payment, int YearEmployee)
        {
            this.Payment = Payment;
            this.Name = Name;
            this.Occupation = Occupation;
            this.YearEmployee = YearEmployee;
        }

        public double Payment { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public int YearEmployee { get; set; }
    }
}