using ProjetoSalario;
using System.Globalization;
using System.Collections.Generic;

List<Funcionario> list = new List<Funcionario>();

Console.Write("Quantas pessoas estão registradas? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Registro #{i}");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Funcionario(id, nome, salario));


}
Console.WriteLine();
Console.Write("Inclua o id do funcionário com aumento de salário: ");
int pesquisa = int.Parse(Console.ReadLine());

Funcionario emp = list.Find(x => x.Id == pesquisa);
if (emp != null)
{
    Console.Write("Entre com o percentual: ");
    double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.ValorIncremento(perc);
}
else
{
    Console.WriteLine("Essa ID não está na lista");
}

Console.WriteLine();
foreach (Funcionario obj in list)
{
    Console.WriteLine(obj);
}
