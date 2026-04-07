
public class Conta
{
    public string? titular;
    public int numeroIdentificacao;
    public decimal saldo;
    public decimal limiteDebito;

    public bool Sacar(decimal valorSaque)
    {

        if (valorSaque > saldo + limiteDebito)
        {
            return false;
        }
        saldo -= valorSaque;

        return true;
    }

    public void Depositar(decimal valorDeposito)
    {

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

