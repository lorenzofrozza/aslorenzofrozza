Documento do Projeto: Sistema de Gerenciamento de Livros em uma Biblioteca

1. Introdução 

  O objetivo deste projeto é criar um sistema de gerenciamento de livros em uma biblioteca, utilizando os princípios da Programação Orientada a Objetos (POO). O sistema será composto por três classes principais: ItemBiblioteca (classe base abstrata), Livro (classe derivada de ItemBiblioteca), e Biblioteca. A classe Program servirá como ponto de entrada para demonstrar as funcionalidades do sistema.

2. Classes e Especificações Técnicas

  2.1 Classe ItemBiblioteca (Classe Base): Propriedades:Id (int): Identificador único do item na biblioteca.Titulo (string): Título do item.DescricaoInterna (string) - Propriedade protegida: Descrição interna do item.Métodos:Construtor: Inicializa Id, Titulo e define um valor padrão para DescricaoInterna.

  2.2 Classe Livro (Classe Derivada de ItemBiblioteca): Propriedades adicionais:Autor (string): Autor do livro.Métodos:Construtor: Recebe id, título e autor, e inicializa a DescricaoInterna.ExibirDescricaoInterna: Método para imprimir a DescricaoInterna.

  2.3 Classe Biblioteca:Propriedades: Itens (List<ItemBiblioteca>): Coleção de itens na biblioteca.Métodos:AdicionarItem: Adiciona um item à coleção.RemoverItem: Remove um item da coleção.BuscarItemPorTitulo (sobrecarga): Busca um item pelo título.BuscarItemPorId (sobrecarga): Busca um item pelo ID.

  2.4 Classe Program (Ponto de Entrada):Métodos: Cria instâncias de Biblioteca e Livro.Demonstração de adição, busca e remoção de livros.Exibição da DescricaoInterna do livro.

3. Abordagem e Conceitos de POO Utilizados

A abordagem do projeto segue os princípios fundamentais da POO, incluindo:

  Abstração: A classe ItemBiblioteca é uma abstração que encapsula as propriedades essenciais comuns a todos os itens na biblioteca.

  Herança: A classe Livro herda da classe base ItemBiblioteca, aproveitando suas propriedades e métodos. Isso promove a reutilização de código.

  Encapsulamento: O encapsulamento é alcançado por meio das propriedades privadas e protegidas, garantindo que o estado interno dos objetos seja controlado e acessado de maneira segura.

  Polimorfismo (sobrecarga): As classes Biblioteca e ItemBiblioteca implementam métodos com sobrecarga, permitindo funcionalidades diferentes com base nos parâmetros fornecidos.

4.Conclusão

  O sistema de gerenciamento de biblioteca desenvolvido neste projeto demonstra uma implementação prática dos conceitos de POO. A hierarquia de classes, o encapsulamento e a utilização de sobrecarga são estratégias essenciais para construir um sistema flexível, extensível e fácil de manter. O uso adequado desses conceitos contribui para a eficácia e inovação no desenvolvimento de software orientado a objetos.

Nome: Lorenzo Taborda Frozza 
