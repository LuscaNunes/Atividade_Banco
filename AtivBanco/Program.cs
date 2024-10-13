using System.Globalization;
using System.Xml.Linq;
Conta cont =  new Conta();

Console.WriteLine("Digite seu nome: ");
cont.nome = Console.ReadLine();

Console.WriteLine("Digite sua Agência");
cont.agencia = Console.ReadLine();
Console.WriteLine("Digite o numero da sua conta: ");
cont.numConta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite seu saldo em conta: ");
cont.saldo = Convert.ToDouble(Console.ReadLine());

string op = "";
int opp = 0;

do
{
    Console.WriteLine("digite D para Depositar");
    Console.WriteLine("Digite S para Sacar");
    op = Console.ReadLine();

    switch (op.ToUpper())
	{
		case "D":
            Console.WriteLine("Atenção não terminamos, Aguarde");
            for (int j = 0; j < 50; j++)
            {
                System.Threading.Thread.Sleep(50);
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("================ Depositar ================");
            Console.WriteLine("Digite o valor de Deposito");
			cont.Depositar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("só um instante estámos verificando");
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(50);
                Console.Write("~");
            }
            Console.WriteLine();
            Console.WriteLine($"{cont.nome} saldo da sua conta é {cont.saldo}");
            Console.WriteLine($"Agência nº{cont.agencia} nº{cont.numConta}");
            break;
		case "S":
            Console.WriteLine("Atenção não terminamos, Aguarde");
            for (int j = 0; j < 50; j++)
            {
                System.Threading.Thread.Sleep(50);
                Console.Write(".");
            }

            Console.WriteLine();
			Console.WriteLine("================ Sacar ================");
			Console.WriteLine("digite o valor de Saque");
			cont.Sacar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("só um instante estámos verificando");
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(50);
                    Console.Write("~");
            }
            Console.WriteLine();
			Console.WriteLine($"{cont.nome} saldo da sua conta é {cont.saldo}");
            Console.WriteLine($"Agência nº{cont.agencia} nº{cont.numConta}");

            break;
		default:
		break;
	}
    Console.WriteLine("Digite 1 para sair ou outro numero para continuar");
	opp = Convert.ToInt32(Console.ReadLine());
} while (opp != 1);