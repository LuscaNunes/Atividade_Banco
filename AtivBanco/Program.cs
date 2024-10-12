using System.Globalization;

//help my Jesus

Conta cont =  new Conta();

Console.WriteLine("Digite seu nome: ");
cont.nome = Console.ReadLine();


Console.WriteLine("Digite sua Agência");
cont.agencia = Console.ReadLine();
Console.WriteLine("Digite o numero da sua conta: ");
cont.numConta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite seu saldo em conta: ");
cont.saldo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite D para Depositar");
Console.WriteLine("Digite S para Sacar");
string op = Console.ReadLine();

switch (op)
{
	case "D":
        Console.WriteLine("Digite o valor de Deposito");
		cont.Depositar(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine($"Saldo de {cont.saldo}");

		break;
	case "S":
		Console.WriteLine("digite o valor de Saque");
		cont.Sacar(Convert.ToDouble(Console.ReadLine()));

		Console.WriteLine($"Saldo de {cont.saldo}");


        break;
	default:
		break;
}
