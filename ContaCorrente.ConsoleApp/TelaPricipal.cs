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
}




