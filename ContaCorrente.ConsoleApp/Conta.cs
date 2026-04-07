
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

    public bool Transferir(Conta contaDestino, decimal valorTransferencia)
    {
        bool conseguiuSacar = this.Sacar(valorTransferencia);

        if (!conseguiuSacar)
        {
            return false;
        }
        contaDestino.Depositar(valorTransferencia);
        return true;

    }

    public void ObterSaldo()
    {
        System.Console.WriteLine($"Saldo: R${saldo}");
        Console.ReadLine();
    }
}

