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

Livro criarLivro(string t, string[] aut, DateOnly lan, string editora, int edicao, string isbn, int qtdP)
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


    livros[0] = criarLivro("Senhor das moscas", new string[] { "William Golding", "Jose de Alenca" }, new DateOnly(1990, 1, 1), "Mapa", 1, "123_1244_213", 450);
    livros[1] = criarLivro("Senhor dos Aneis", new string[] { "J.R.R. Tolkien" }, new DateOnly(1932, 10, 12), "Mapa", 4, "400_1244_213", 750);
    livros[2] = criarLivro("Don Casmurro", new string[] { "Machado de Assis", "Jose Gamarra" }, new DateOnly(2000, 4, 10), "Vagalume", 5, "123_1677_213", 350);
    livros[3] = criarLivro("1984", new string[] { "George Orwell" }, new DateOnly(1949, 6, 8), "Tauros", 2, "789_4567_890", 350);
    livros[4] = criarLivro("Dom Quixote", new string[] { "Miguel de Cervantes", "Maria Natany" }, new DateOnly(1605, 1, 16), "Palpoa", 3, "567_8901_234", 300);
    livros[5] = criarLivro("A Revolução dos Bichos", new string[] { "George Orwell" }, new DateOnly(1945, 8, 17), "Ziriguidun", 1, "345_6789_012", 400);
    livros[6] = criarLivro("O Pequeno Príncipe", new string[] { "Antoine de Saint-Exupéry" }, new DateOnly(1943, 4, 6), "Talat", 2, "901_2345_678", 250);
    livros[7] = criarLivro("Cem Anos de Solidão", new string[] { "Gabriel García Márquez", "Carlos Lacerda", "Leticia Morkely" }, new DateOnly(1967, 5, 30), "ManausEditora", 3, "678_9012_345", 320);
    livros[8] = criarLivro("Harry Potter e a Pedra Filosofal", new string[] { "J.K. Rowling" }, new DateOnly(1997, 6, 26), "Nova VIbe", 1, "456_7890_123", 380);
    livros[9] = criarLivro("Crime e Castigo", new string[] { "Fiódor Dostoiévski", "Fernando Black", "Bartolomeu Clark","Nataly Novak","Elliot Stabler" }, new DateOnly(1866, 1, 1), "Eu tentei", 2, "234_5678_901", 280);

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