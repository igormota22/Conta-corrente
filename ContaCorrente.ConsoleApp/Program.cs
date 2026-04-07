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
            string? opcaoMenu = tela.ExibirMenu(conta1);

            if (opcaoMenu == "S")
            {
                break;
            }

            switch (opcaoMenu)
            {
                case "1":
                    tela.ExibirOperacaoSaque(conta1);
                    break;

                case "2":
                    tela.ExibirOperacaoDeposito(conta1);
                    break;

                case "3":
                    tela.ExibirOperacaoTranferencia(conta1, conta2);
                    break;

                case "4":
                    tela.ExibirSaldo(conta1); //conta que tranfere (conta1)
                    tela.ExibirSaldo(conta2); //conta que recebe (conta2)
                    break;

                default:
                    System.Console.WriteLine("Informe uma operação valida");
                    return;
            }
        }

    }


}


