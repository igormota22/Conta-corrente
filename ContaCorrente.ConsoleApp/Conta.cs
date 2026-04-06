
public class Conta
{
    public string? titular;
    public int numeroIdentificacao;
    public decimal saldo;
    public decimal limiteDebito;

    public void Sacar()
    {
        System.Console.Write("Informe o valor que deseja sacar:");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= -limiteDebito)
        {
            System.Console.WriteLine("O valor de limite de debito ja foi ultrapassado");
            Console.ReadLine();
            return;
        }
        else
        {

            saldo -= valorSaque;
            System.Console.WriteLine("O valor foi sacado com sucesso");
            Console.ReadLine();
        }
    }

    public void Depositar()
    {
        System.Console.Write("Informe o valor que deseja depositar:");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;
    }

    public void Transferir(Conta contaDestino)
    {
        System.Console.Write("Informe o valor que deseja transferir:");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        saldo -= valorTransferencia;
        contaDestino.saldo += valorTransferencia;

        System.Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso");
        Console.ReadLine();

    }

    public void ObterSaldo()
    {
        System.Console.WriteLine($"Saldo: R${saldo}");
        Console.ReadLine();
    }
}

