
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        Conta conta1 = new Conta();
        conta1.titular = "Igor";
        conta1.numeroIdentificacao = 1;
        conta1.saldo = 1000;
        conta1.limiteDebito = 1200;

        Conta conta2 = new Conta();
        conta2.titular = "Rech";
        conta2.numeroIdentificacao = 2;
        conta2.saldo = 1000;
        conta2.limiteDebito = 1200;

        while (true)
        {
            ExibirMenu(conta1.numeroIdentificacao, conta1.titular);
            System.Console.Write("Escolha a operação desejada:");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
            {
                break;
            }

            switch (opcaoMenu)
            {
                case "1":
                    System.Console.Write("Informe o valor que deseja sacar:");
                    decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                    conta1.Sacar(valorSaque);

                    if (!conta1.Sacar(valorSaque))
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
                    break;

                case "2":

                    conta1.Depositar();
                    break;

                case "3":

                    conta1.Transferir(conta2);
                    break;

                case "4":

                    conta1.ObterSaldo();
                    break;

                default:
                    System.Console.WriteLine("Informe uma operação valida");
                    return;
            }
        }

    }

    static void ExibirMenu(int numeroIdentificacao, string titular)
    {
        // Console.Clear();
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine($"Conta Corrente {numeroIdentificacao} de {titular}");
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine("1 - Saque");
        System.Console.WriteLine("2 - Deposito");
        System.Console.WriteLine("3 - Transferir");
        System.Console.WriteLine("4 - Consultar Saldo");
        System.Console.WriteLine("S - Sair");

    }
}

