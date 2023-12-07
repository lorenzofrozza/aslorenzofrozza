public class Biblioteca
{
    public List<ItemBiblioteca> colecaoDaBiblioteca = new List<ItemBiblioteca>();

    public void AdicionarItem()
    {
        Console.Clear();
        Console.WriteLine("\n- Adicionando livro -");
        int id = colecaoDaBiblioteca.Count() + 1;
        Console.Write($"\nDigite o titulo do livro: ");
        string titulo = Console.ReadLine().ToLower();
        Console.Write($"\nDigite o nome do autor: ");
        string autor = Console.ReadLine();

        Livro livro = new(id, titulo, autor);
        colecaoDaBiblioteca.Add(livro);

        Console.WriteLine($" \n--> Livro adicionado com sucesso ");
    }

    public void RemoverItem()
    {
        Console.Clear();
        Console.WriteLine($"\n - Livros da Biblioteca - ");
        foreach (Livro livro in colecaoDaBiblioteca)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Id: {livro.Id}\nTitulo: {livro.Titulo}");
        }
        Console.Write($"\n- Digite o ID do livro que você quer remover: ");
        int remove = Convert.ToInt32(Console.ReadLine());
        colecaoDaBiblioteca.RemoveAt(remove - 1);
        foreach (Livro item in colecaoDaBiblioteca)
        {
            if (item.Id > remove)
            {
                item.Id--;
            }
        }
        Console.WriteLine($" \n--> Livro removido com sucesso");
    }
    public void BuscarItemPorTitulo()
    {
        Console.Clear();
        Console.WriteLine($"\n - Buscando por Titulo - ");
        Console.Write($"\n Digite o titulo do livro: ");
        string nomeLivro = Console.ReadLine().ToLower();
        bool tituloProcura = false;

        Console.Clear();
        Console.WriteLine("\n- Livros Encontrados -");
        foreach (Livro element in colecaoDaBiblioteca)
        {
            if (element.Titulo.Contains(nomeLivro))
            {
                Console.WriteLine($"\nTitulo - {element.Titulo}\nAutor - {element.Autor} \nDescrição interna: {element.ExibirDescricaoInterna()}");
                tituloProcura = true;
                break;
            }
        }
        if (tituloProcura == false)
        {
            Console.WriteLine("\n--> Nenhum livro encontrado ");
        }
        Console.WriteLine("");
    }
    public void BuscarItemPorTitulo(string titulo) // sobrecarga de métodos /polimorfismo
    {
        bool tituloProcura = false;

        foreach (Livro livro in colecaoDaBiblioteca)
        {
            if (livro.Titulo.Contains(titulo))
            {
                Console.WriteLine($"\nId - {livro.Id}\nTitulo - {livro.Titulo}\nAutor - {livro.Autor} \nDescrição interna: {livro.ExibirDescricaoInterna()}");
                tituloProcura = true;
                break;
            }
        }
        if (tituloProcura == false)
        {
            Console.WriteLine("\n--> Nenhum livro encontrado ");
        }
        Console.WriteLine("");
    }
    public void BuscarItemPorId()
    {
        Console.Clear();
        Console.WriteLine($"\n - Buscando por ID- ");
        Console.Write($"\nDigite o id do livro que voce quer ver as informações: ");
        int info = Convert.ToInt32(Console.ReadLine());
        bool idProcura = false;
        foreach (Livro item in colecaoDaBiblioteca)
        {
            if (info == item.Id)
            {
                Console.WriteLine($"\nTitulo: {item.Titulo}\nAutor: {item.Autor} \nDescrição interna: {item.ExibirDescricaoInterna()}");
                idProcura = true;
                break;
            }
        }
        if (idProcura == false)
        {
            Console.Write("\n--> Nenhum livro encontrado ");
        }
        Console.WriteLine("");
    }
    public void BuscarItemPorId(int id) // sobrecarga de métodos /polimorfismo
    {
        bool idProcura = false;
        foreach (Livro item in colecaoDaBiblioteca)
        {
            if (id == item.Id)
            {
                Console.WriteLine($"\nId: {item.Id}\nTitulo: {item.Titulo}\nAutor: {item.Autor} \nDescrição interna: {item.ExibirDescricaoInterna()}");
                idProcura = true;
                break;

            }
            if (idProcura == false)
            {
                Console.Write("\n--> Nenhum livro encontrado");
            }
        }
        Console.WriteLine("");
    }

    public void ListarLivros()
    {
        Console.Clear();
        Console.WriteLine($"\n- Livros da biblioteca - ");
        foreach (Livro livro in colecaoDaBiblioteca)
        {
            Console.WriteLine($"\nTitulo: {livro.Titulo}\nAutor: {livro.Autor} \nDescrição interna: {livro.ExibirDescricaoInterna()}");
        }
        Console.WriteLine("");
    }
}