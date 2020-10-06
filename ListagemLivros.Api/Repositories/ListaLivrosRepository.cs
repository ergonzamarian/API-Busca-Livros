using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using ListagemLivros.Api.Model;


namespace ListagemLivros.Api.Repositories
{

    public class ListaLivrosRepository : IListaLivrosRepository
    {
        
        private readonly List<Livros> resultado;
        public ListaLivrosRepository(List<Livros> resultado)
        {
            this.resultado = new List<Livros>();
        }
        
        public static List<Livros> ConverterJson()
        {   
           
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"c:\books.json");
            var js = new DataContractJsonSerializer(typeof(List<Livros>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var livros_json = (List<Livros>)js.ReadObject(ms);
            return livros_json;
   
        }
        

        //variável do tipo somente leitura
    
        /*
        [] IEnumerable<Livros> ListarLivros();
        [] Livros BuscaLivroId(Guid id);
        [] Livros BuscaLivroName(Guid name);
        [] Livros BuscaLivroPrice(Guid price);
        [] Livros BuscaLivroOriginallyPublished(Guid Originally_published);
        [] Livros BuscaLivroAuthor(Guid Author);
        [] Livros BuscaPageCount(Guid Page_count);
        [] Livros BuscaIllustrator(Guid Illustrator);
        [] Livros BuscaGenres(Guid Genres);
        [] Ordenar Crescente pelo preço.
        [] Ordenar Decrescente pelo preço.
        [] Calcular Frete em 20% o valor do livro. 
            Ordenar o Array	
            Array.Sort(livros)
            
            Inverter a ordem dos itens no Array	
            Array.Reverse(livros)
        */
        List<Livros> livros_json = ConverterJson();
        
        public IEnumerable<Livros> ListarLivros()
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {    
                resultado.Add(ConverterJson()[i]);
                
            }
            return (List<Livros>)resultado;

        }
        public Livros BuscaLivroId(int Id)
        {
            //Parte muito importante retornar o elemento da lista quando o Id passado como parâmetro for igual o Id da lista
            return ConverterJson().FirstOrDefault(x => x.id == Id);
        }

        public List<Livros> BuscaLivroName(string Name)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   
                if(ConverterJson()[i].name == Name)
                {   
                    resultado.Add(ConverterJson()[i]);
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaLivroPrice(double Price)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   
                if(ConverterJson()[i].price == Price)
                {   
                    resultado.Add(ConverterJson()[i]);
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaLivroOriginallyPublished(string Originally_published)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   
                if(ConverterJson()[i].specifications.Originallypublished == Originally_published)
                {   
                    resultado.Add(ConverterJson()[i]);
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaLivroAuthor(string author)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   
                if(ConverterJson()[i].specifications.Author == author)
                {   
                    resultado.Add(ConverterJson()[i]);
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaPageCount(int Page_count)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   
                if(ConverterJson()[i].specifications.Pagecount == Page_count)
                {   
                    resultado.Add(ConverterJson()[i]);
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaIllustrator(List<string> illustrator)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   for (int j = 0; i < 4; i++)
                {   
                    if(ConverterJson()[i].specifications.Illustrator[i] == illustrator[j])
                    {   
                        resultado.Add(ConverterJson()[i]);
                    }
                }
            }
            return (List<Livros>)resultado;
        }

        public List<Livros> BuscaGenres(List<string> genres)
        {
            resultado.Clear();
            for (int i = 0; i < 6 ; i++)
            {   for (int j = 0; i < 7; i++)
                {   
                    if(ConverterJson()[i].specifications.Genres[i] == genres[j])
                    {   
                        resultado.Add(ConverterJson()[i]);
                    }
                }
            }
            return (List<Livros>)resultado;
        }

        List<Livros> IListaLivrosRepository.OrdenarC()
        {
            
             return (List<Livros>)resultado.OrderBy(livro => livro.price);
                
        }

        List<Livros> IListaLivrosRepository.OrdenarD()
        {
            return (List<Livros>)resultado.OrderByDescending(livro => livro.price);
        }

        List<double> IListaLivrosRepository.Frete()
        {
            throw new NotImplementedException();
        }

        List<double> IListaLivrosRepository.Frete()
        {
            List<double> frete;
            for (int i = 0; i < 6; i++)
            {  
                frete.Add(ConverterJson()[i].price*0.2);

            }
            return frete;
        }
    }
}