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

        TelaPricipal tela = new TelaPricipal();

        while (true)
        {
            Console.Clear();
            string opcaoMenu = tela.ExibirMenu(conta1);

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
                    System.Console.Write("Informe o valor que deseja depositar:");
                    decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

                    conta1.Depositar(valorDeposito);
                    break;

                case "3":
                    System.Console.Write("Informe o valor que deseja transferir:");
                    decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

                    conta1.Transferir(conta2, valorTransferencia);

                    System.Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso");
                    Console.ReadLine();
                    if (!conta1.Transferir(conta2, valorTransferencia))
                    {
                        System.Console.WriteLine("A tranferencia falhou");
                        Console.ReadLine();
                    }
                    else
                    {
                        System.Console.WriteLine("Tranferencia feita com sucesso");
                        Console.ReadLine();

                    }
                    break;

                case "4":

                    System.Console.WriteLine($"Seu saldo é de: {conta1.ObterSaldo()}");
                    Console.ReadLine();


                    break;

                default:
                    System.Console.WriteLine("Informe uma operação valida");
                    return;
            }
        }

    }


}


