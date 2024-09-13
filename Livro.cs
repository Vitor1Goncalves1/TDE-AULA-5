Livro livro1 = new Livro();
livro1.titulo = "SPQR";
livro1.autor = "Mary beard";
livro1.ano = 2015;
livro1.paginas = 560;

livro1.informacoes();

Livro livro2 = new Livro();
livro2.titulo = "A arte da guerra";
livro2.autor = "sun tzu";
livro2.ano = 400;
livro2.paginas = 128;

livro2.informacoes();
livro2.TemMaisDe300Paginas();

if(livro2.TemMaisDe300Paginas())
{
    Console.WriteLine("Tem mais de 300 páginas!");
}
else
{
    Console.WriteLine("Tem menos de 300 páginas!");
}

