using System;
using System.Collections.Generic;
using ListagemLivros.Api.Model;

namespace ListagemLivros.Api.Repositories
{
    
    public interface IListaLivrosRepository
    {
        IEnumerable<Livros> ListarLivros();
        Livros BuscaLivroId(int id);
        List<Livros> BuscaLivroName(String name);
        List<Livros> BuscaLivroPrice(double price);
        List<Livros> BuscaLivroOriginallyPublished(String Originally_published);
        List<Livros> BuscaLivroAuthor(String Author);
        List<Livros> BuscaPageCount(int Page_count);
        List<Livros> BuscaIllustrator(List<string> Illustrator);
        List<Livros> BuscaGenres(List<string> Genres);
        List<Livros> OrdenarC();
        List<Livros> OrdenarD();
        List<double> Frete();
        
        
    }
}