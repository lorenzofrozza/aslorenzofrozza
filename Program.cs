Biblioteca b1 = new(); //instancia da classe bilbioteca

do
{
    Console.Clear(); //menu
    Console.WriteLine($"\n- Biblioteca Digital -");
    Console.WriteLine($"-------------------------------------------------------");
    Console.WriteLine($"");
    Console.WriteLine($"1 - Adicionar Livro -");
    Console.WriteLine($"\n2 - Remover Livro -");
    Console.WriteLine($"\n3 - Listar Livros -");
    Console.WriteLine($"\n4 - Buscar livro por Titulo - ");
    Console.WriteLine($"\n5 - Buscar livro por Id -");
    Console.WriteLine($"");
    Console.WriteLine("\n- Opção Desejada - ");
    Console.Write(" \n --> ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) //condicao para caso 
    {
        case 1:
            b1.AdicionarItem(); // chamando os metodos
            break;
        case 2:
            b1.RemoverItem();
            break;
        case 3:
            b1.ListarLivros();
            break;
        case 4:
            b1.BuscarItemPorTitulo();
            break;
        case 5:
            b1.BuscarItemPorId();
            break;
        default:
            Console.WriteLine($"Opçao invalida");
            break;
    }

    Console.WriteLine($""); //geração de novas alterações
    Console.WriteLine("\n- Enter para continuar fazendo alterações na biblioteca - \n- 0 para fechar - ");
    Console.Write(" \n --> ");

} while (Console.ReadLine() == "");
