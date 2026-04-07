public class TelaPricipal
{
    public string ExibirMenu(Conta contaAcessada)
    {
        // Console.Clear();
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine($"Conta Corrente {contaAcessada.numeroIdentificacao} de {contaAcessada.titular}");
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine("1 - Saque");
        System.Console.WriteLine("2 - Deposito");
        System.Console.WriteLine("3 - Transferir");
        System.Console.WriteLine("4 - Consultar Saldo");
        System.Console.WriteLine("S - Sair");
        System.Console.Write("Escolha a operação desejada:");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }

    public void ExibirOperacaoSaque(Conta contaAcessada)
    {
        System.Console.Write("Informe o valor que deseja sacar:");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        contaAcessada.Sacar(valorSaque);

        if (!contaAcessada.Sacar(valorSaque))
        {
            System.Console.WriteLine("O valor de limite de debito ja foi ultrapassado");
            Console.ReadLine();
            return;
        }
        else
        {
            System.Console.WriteLine("O valor foi sacado com sucesso");
            Console.ReadLine();
        }
    }

    public void ExibirOperacaoDeposito(Conta contaAcessada)
    {
        System.Console.Write("Informe o valor que deseja depositar:");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaAcessada.Depositar(valorDeposito);
    }
}




