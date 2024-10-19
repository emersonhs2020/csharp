/******************************************************************************
Philippe Ribeiro
PI04 - IEFP - Ranholas
Prof. Carlos Álvares - UFCD 3935 - Progamação C#
*******************************************************************************

int opcao;
    string[] prato = new string[3];
    double[] preco = new double[3];
    Console.WriteLine("**************************");
    Console.WriteLine("            MENU          ");
    Console.WriteLine("**************************\n");
    Console.WriteLine("Escolha uma das opções abaixo:\n");
    Console.WriteLine("0 - Lasanha");
    Console.WriteLine("1 - Bacalhau");
    Console.WriteLine("2 - Risoto");
    Console.WriteLine("2 - Risoto");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
      case 0:
        prato[opcao] = "Lasanha";
        preco[opcao] = 4.90;
        Console.WriteLine("O Cliente escolheu " + prato[opcao] + " e o valor é de " + preco[opcao]);
        break;
      case 1:
        prato[opcao] = "Bacalhau";
        preco[opcao] = 14.90;
        Console.WriteLine("O Cliente escolheu " + prato[opcao] + " e o valor é de " + preco[opcao]);
        break;
      case 2:
        prato[opcao] = "Risoto";
        preco[opcao] = 5.90;
        Console.WriteLine("O Cliente escolheu " + prato[opcao] + " e o valor é de " + preco[opcao]);
        break;
      default:
        Console.WriteLine("Escolha um opção válida.");
        break;  
    } // End Switch