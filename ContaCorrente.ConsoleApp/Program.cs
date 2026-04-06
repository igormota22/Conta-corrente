/*
Atributos

ID de identificação
titular
saldo disponivel
limite de debito

Acoes da conta

saque
deposito
tranferencia
consulta de saldo
*/



using System.Security.Cryptography;

string titular = "Igor";
int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
decimal saldo = 1000;
decimal saldo2 = 1000;
decimal limiteDebito = 1200;
while (true)
{
    Console.Clear();
    System.Console.WriteLine("--------------------------------");
    System.Console.WriteLine($"Conta Corrente {numeroIdentificacao} de {titular}");
    System.Console.WriteLine("--------------------------------");
    System.Console.WriteLine("1 - Saque");
    System.Console.WriteLine("2 - Deposito");
    System.Console.WriteLine("3 - Transferir");
    System.Console.WriteLine("4 - Consultar Saldo");
    System.Console.WriteLine("S - Sair");
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
            break;

        case "2":
            System.Console.Write("Informe o valor que deseja depositar:");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

            saldo += valorDeposito;
            break;
        case "3":
            System.Console.Write("Informe o valor que deseja transferir:");
            decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

            saldo -= valorTransferencia;
            saldo2 += valorTransferencia;

            System.Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso");
            Console.ReadLine();

        break;
        case "4":
            System.Console.WriteLine($"Saldo: R${saldo}");
            Console.ReadLine();
            break;

        default:
            System.Console.WriteLine("Informe uma operação valida");
            return;
    }




}
