/********************************************************************************
Andrii Dobrykov
IEFP-PI04 Programação em C#

Exercício 1

Nome do projeto: "Menu"

Usando a função Switch e Arrays

 -  Fazer um menu de refeições para o utilizador escolher uma das opções e
    guardar num array o prato e o valor do parato    
 -  Imprimir o preço e o prato escolhido que estão guardados no array
********************************************************************************/

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine("Nome do projeto: Menu (Usando a função Switch e Arrays)");
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine();

                    //---- início do codigo principal ----

                    string[] pratos = {"Feijoada", "Salada de Quinoa", "Wrap de Falafel", "Lasanha de Abobrinha", "Espetinho de Legumes"};
                    double[] precos = {5.00, 6.00, 7.50, 9.00, 7.00};

                    Console.WriteLine("Menu de Refeições:"                      );
                    Console.WriteLine(                                          );
                    Console.WriteLine("Escolha uma das opções abaixo (1-5)  \n" );
                    Console.WriteLine("1. Feijoada             - 5.00 euro"     );
                    Console.WriteLine("2. Salada de Quinoa     - 6.00 euro"     );
                    Console.WriteLine("3. Wrap de Falafel      - 7.50 euro"     );
                    Console.WriteLine("4. Lasanha de Abobrinha - 9.00 euro"     );
                    Console.WriteLine("5. Espetinho de Legumes - 7.00 euro"     );
                    Console.WriteLine(                                          );

                    int escolha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (escolha)
                    {
                        case 1:
                            // Imprimir o preço e o prato escolhido
                            Console.WriteLine("Você escolheu"                                         );
                            Console.WriteLine("               prato: " + pratos[escolha - 1]          );
                            Console.WriteLine("               preço: " + precos[escolha - 1] + " euro");
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu");
                            Console.WriteLine("               prato: " + pratos[escolha - 1]);
                            Console.WriteLine("               preço: " + precos[escolha - 1] + " euro");
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu");
                            Console.WriteLine("               prato: " + pratos[escolha - 1]);
                            Console.WriteLine("               preço: " + precos[escolha - 1] + " euro");
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu");
                            Console.WriteLine("               prato: " + pratos[escolha - 1]);
                            Console.WriteLine("               preço: " + precos[escolha - 1] + " euro");
                            break;
                        case 5:
                            Console.WriteLine("Você escolheu");
                            Console.WriteLine("               prato: " + pratos[escolha - 1]);
                            Console.WriteLine("               preço: " + precos[escolha - 1] + " euro");
                            break;
                        default:
                            Console.WriteLine("Opção não existe");
                            break;
                    }

                    //---- fim do codigo ----

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Este é um loop infinito com entrada do teclado!");
                    Console.WriteLine("Pressione 'q' para sair e ENTER (ou qualquer outra tecla) para continuar.");
                    Console.WriteLine("*******************************************************************************");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.KeyChar == 'q')
                    {
                        continuar = false;
                    }
                }                
            }
        }
    }
}
