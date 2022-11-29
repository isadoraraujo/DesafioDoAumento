using DesafioDoAumento.Class;

double porcentagem;
int op;

List<Employee> employee = new List<Employee>();

OldEmployee oldEmployee = new OldEmployee();

while (true)
{
    Console.WriteLine("Digite 1 para começar\n0 para sair");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 0: Environment.ExitCode = 0;
            break;

        case 1:
            Employee newEmployee = new Employee();

            Console.WriteLine("Digite seu nome: ");
            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Digite seu cargo: ");
            newEmployee.Occupation = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            newEmployee.Payment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a data da sua admissão: ");
            newEmployee.YearEmployee = Convert.ToInt32(Console.ReadLine());

            if (newEmployee.Payment > 7000 && newEmployee.YearEmployee < 2021)
            {
                oldEmployee.lista.Add(newEmployee);
                newEmployee.Payment = (newEmployee.Payment * 0.1) + newEmployee.Payment;
            }
            else
            {
                Console.WriteLine("Qual é o aumento? ");
                porcentagem = Convert.ToDouble(Console.ReadLine());
                newEmployee.Payment = ((porcentagem / 100) * newEmployee.Payment) + newEmployee.Payment;
            }

            employee.Add(newEmployee);

            Console.WriteLine($"nome: {newEmployee.Name}\ncargo: {newEmployee.Occupation}\nsalário aumentado: {newEmployee.Payment}\n");
            break;

        case 2:
            foreach (var item in employee)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Occupation);
                Console.WriteLine(item.Payment);
                Console.WriteLine(item.YearEmployee);
                Console.WriteLine("************");
            }
            break;

        case 3:
            foreach(var item in oldEmployee.lista)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Occupation);
                Console.WriteLine(item.Payment);
                Console.WriteLine(item.YearEmployee);
                Console.WriteLine("************");
            }
            break;
    }
}