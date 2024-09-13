class Livro{
    public string titulo;

    public string autor;

    public int ano;

    public int paginas;

    public void informacoes()
    {
        Console.WriteLine($"Autor: {autor}\nTitulo: {titulo}\nAno: {ano}\nPaginas");
    }

    public bool TemMaisDe300Paginas()
    {
        return paginas > 300;
    }
}
