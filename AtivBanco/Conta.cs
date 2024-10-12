public class Conta
{
    public int numConta;
    public string agencia;
    public string nome;
    public double saldo;

    public void Depositar(double valorDepo)
    {
        if (valorDepo < 0)
        {
            Console.WriteLine("valor negativo");
        }
        else
        {
            saldo = saldo + valorDepo;
        }
    }

    public void Sacar(double valorSacar)
    {
        if (valorSacar > saldo || valorSacar <=0)
        {
            Console.WriteLine("saldo insuficiente ou valor inválido");
        }
        else
        {
            Console.WriteLine("Saldo suficiente");
            saldo = saldo - valorSacar;
            //Console.WriteLine($"Saldo da Conta {valorSacar}");
        }
    }
}