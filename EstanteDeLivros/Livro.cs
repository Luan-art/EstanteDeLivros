using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Livro
{
    public string titulo;
    public string autores;
    public DateOnly lancamento;
    public string editora;
    public int edicao;
    public string ISBN;
    public int qtdPagina;

    public Livro()
    {
    
    }

    public void DefinirTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void DefinirAutores(string autores)
    {
        this.autores = autores;
    }
    public void DefinirEditora(string editora)
    {
        this.editora = editora;
    }
    public void DefinirIsbn(string ISBN)
    {
        this.ISBN = ISBN;
    }

    public void DefinirLancamento(DateOnly lancamento)
    {
        this.lancamento = lancamento;
    }

    public void DefinirEdicao(int edicao)
    {
        this.edicao = edicao;
    }

    public void DefinirQtdPaginas(int qtdPagina)
    {
        this.qtdPagina = qtdPagina;
    }

    public void ImprimirLivro()
    {
        Console.WriteLine();
        Console.WriteLine("Titulo:" + titulo);
        Console.WriteLine("Autores: " + autores);
        Console.WriteLine("Editora: " + editora);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Edição: " +edicao);
        Console.WriteLine("Laçamento: " + lancamento.ToString());
        Console.WriteLine("qtdPaginas: " + qtdPagina);
        Console.WriteLine();

    }

}

