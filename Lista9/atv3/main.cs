/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    Produtos pd = new Produtos();
    
    while (true)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Adicionar produto");
        Console.WriteLine("2. Exibir lista de produtos");
        Console.WriteLine("3. Finalizar venda");
        Console.WriteLine("4. Sair");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Produto: ");
                pd.produto = Console.ReadLine();
                Console.WriteLine("Valor: ");
                pd.valor = decimal.Parse(Console.ReadLine());
                    
                pd.AdicionarCarrinho();
                break;

            case "2":
                pd.ExibirCarrinho();
                break;

            case "3":
                pd.TotalPagar();
                break;
                
            case "4":
                Console.WriteLine("Encerrando ...\n");
                return;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.\n");
                break;
        }
    }

    }
}
