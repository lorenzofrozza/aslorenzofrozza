public abstract class ItemBiblioteca
{
    public int Id { get; set; } //propriedade publica 
    public string Titulo { get; set; } //propriedade publica 
    protected string DescricaoInterna { get; set; } // propriedade protegida

    public ItemBiblioteca(int id, string titulo)
    {
        this.Id = id;
        this.Titulo = titulo;
        this.DescricaoInterna = " - Descrição do Livro -";
    }
}