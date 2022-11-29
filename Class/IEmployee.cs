using System;

namespace DesafioDoAumento.Class
{
    internal interface IEmployee
    {
        public double Payment { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public int YearEmployee { get; set; }   
    }
}
