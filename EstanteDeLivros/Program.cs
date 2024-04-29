Livro[] livros = prencherEstante();

switch (imprimirMenu())
{
    case 1:
        imprimirTodaEstante(livros);
        break;

    case 2:
        ImprimirUmLivroEspecifico(digitarValorIndice());
        break;
    default:
        Console.WriteLine("VOLTE SEMPRE!!!");
        break;

}

void ImprimirUmLivroEspecifico(int v)
{
    livros[v].ImprimirLivro();
}

int digitarValorIndice()
{
    int opcao;

    do
    {
        Console.WriteLine("Qual livro gostaria de acessar: ");
        opcao = int.Parse(Console.ReadLine());

    }while (opcao < 0 || opcao >= 9);

    return opcao;

}

void imprimirTodaEstante(Livro[] livros)
{
    for(int i = 0; i < livros.Length; i++)
    {
        livros[i].ImprimirLivro();
    }
}

Livro criarLivro(string t, string aut, DateOnly lan, string editora, int edicao, string isbn, int qtdP)
{
    Livro livro = new Livro();

    livro.DefinirTitulo(t);

    livro.DefinirAutores(aut);

    livro.DefinirLancamento(lan);

    livro.DefinirEditora(editora);

    livro.DefinirEdicao(edicao);

     livro.DefinirIsbn(isbn);

     livro.DefinirQtdPaginas(qtdP);

    return livro;
}

Livro[] prencherEstante()
{
    Livro[] livros = new Livro[10];

    livros[0] = criarLivro("Senhor das moscas", "joge amado", new DateOnly(1990, 1, 1), "Mapa", 1, "123_1244_213", 450);
    livros[1] = criarLivro("Senhor dos Aneis", "Tolkein", new DateOnly(1932, 10, 12), "Mapa", 4, "400_1244_213", 750);
    livros[2] = criarLivro("Don Casmurro", "Machado de Assis", new DateOnly(2000, 4, 10), "Vagalume", 5, "123_1677_213", 350);
    livros[3] = criarLivro("1984", "George Orwell", new DateOnly(1949, 6, 8), "Tauros", 2, "789_4567_890", 350);
    livros[4] = criarLivro("Dom Quixote", "Miguel de Cervantes", new DateOnly(1605, 1, 16), "Palpoa", 3, "567_8901_234", 300);
    livros[5] = criarLivro("A Revolução dos Bichos", "George Orwell", new DateOnly(1945, 8, 17), "Ziriguidun", 1, "345_6789_012", 400);
    livros[6] = criarLivro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", new DateOnly(1943, 4, 6), "Talat", 2, "901_2345_678", 250);
    livros[7] = criarLivro("Cem Anos de Solidão", "Gabriel García Márquez", new DateOnly(1967, 5, 30), "ManausEditora", 3, "678_9012_345", 320);
    livros[8] = criarLivro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", new DateOnly(1997, 6, 26), "Nova VIbe", 1, "456_7890_123", 380);
    livros[9] = criarLivro("Crime e Castigo", "Fiódor Dostoiévski", new DateOnly(1866, 1, 1), "Eu tentei", 2, "234_5678_901", 280);

    return livros;
}

int imprimirMenu()
{
    int opcao;

    Console.WriteLine("Digite se deseja imprimir toda estante - 1");
    Console.WriteLine("Digite se deseja imprimir um livro especifico - 2");
    Console.WriteLine("Digite qualquer outro numero para sair");


    opcao = int.Parse(Console.ReadLine());

    return opcao;

}