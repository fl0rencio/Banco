using Banco;
using System.Globalization;

Cliente cliente;

Console.Write("ENTRE COM O NUMERO DA CONTA: ");
int conta = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("DIGITE O NOME DO TITULAR DA CONTA: ");
string titular = Console.ReadLine();
Console.WriteLine();

Console.Write("HAVERA DEPOSITO INICIAL? (s / n) ");
char simOuNao = char.Parse(Console.ReadLine());

if (simOuNao == 's' || simOuNao == 'S')
{
    Console.WriteLine();
    Console.Write("Digite o valor do deposito incial: ");
    double saldoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    cliente = new Cliente(saldoInicial,conta,titular);
    

    
}
else
{
     cliente = new Cliente(conta, titular);
    
}

Console.WriteLine();
Console.WriteLine("DADOS DA CONTA: ");
Console.WriteLine(cliente);

Console.WriteLine();
Console.Write("Qual valor para deposito? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cliente.Depositar(quantia);
Console.WriteLine();
Console.Write("DADOS DA CONTA ATUALIZADOS : ");
Console.WriteLine(cliente);

Console.WriteLine();
Console.Write("Digite o valor desejado para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cliente.Sacar(quantia);
Console.WriteLine();
Console.Write("DADOS DA CONTA ATUALIZADOS : ");
Console.WriteLine(cliente);






