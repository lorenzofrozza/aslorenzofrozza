public class Livro : ItemBiblioteca // herança
{
    public string Autor { get; set; } //propriedade publica / encapsulamento

    public Livro(int id, string titulo, string autor) : base(id,titulo)
    {
        this.Autor = autor;
        Console.Write($"\nDigite a descrição do livro: ");
        this.DescricaoInterna = Console.ReadLine();
    }
    public string ExibirDescricaoInterna()
    {
        return DescricaoInterna;
    }
}