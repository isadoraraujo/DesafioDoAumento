namespace DesafioDoAumento.Class
{
    class OldEmployee : Employee
    {
        public List<Employee> lista { get; set; }
        public OldEmployee()
        {
            this.lista = new List<Employee>();
        }
    }
}