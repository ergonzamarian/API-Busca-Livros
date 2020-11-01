using System;
using Microsoft.AspNetCore.Mvc;
using ListagemLivros.Api.Repositories;
using System.Collections.Generic;
using ListagemLivros.Api.Model;


//O caminho se trata de "v1/" uma vez que v1 me ajuda a controlar as versões caso no futuro eu deseje mudar e existam usuários que não se adequem a versões novas

namespace ListagemLivros.Api.Controllers
{
    public class ListaLivrosController:Controller
    {
        
        public readonly IListaLivrosRepository _repositorio;

        public ListaLivrosController(IListaLivrosRepository repositorio)
        {
            _repositorio = repositorio;
        }
        
        
        [HttpGet("v1/listarlivros/todos")]
        public IActionResult ListarLivros([FromBody]Livros livros)
        {
            return Ok(_repositorio.ListarLivros());
        }

        [HttpGet("v1/id/{id}")]
        public IActionResult BuscaLivroId(int id, [FromBody]Livros livros)
        {
            return Ok(_repositorio.BuscaLivroId(id));
        }
        
        [HttpGet("v1/name/{name}")]
        public IActionResult BuscaLivroName(String name)
        {
            return Ok(_repositorio.BuscaLivroName(name));
        }

        [HttpGet("v1/price/{price}")]
        public IActionResult BuscaLivroPrice(double price)
        {
            return Ok(_repositorio.BuscaLivroPrice(price));
        }

        [HttpGet("v1/Originally_published/{Originally published}")]
        public IActionResult BuscaLivroOriginallyPublished(String Originally_published )
        {
            return Ok(_repositorio.BuscaLivroOriginallyPublished(Originally_published));
        }

        [HttpGet("v1/Author/{Author}")]
        public IActionResult BuscaLivroAuthor(String Author )
        {
            return Ok(_repositorio.BuscaLivroAuthor(Author));
        }

        [HttpGet("v1/Page_count/{Page count}")]
        public IActionResult BuscaPageCount(int Page_count )
        {
            return Ok(_repositorio.BuscaPageCount(Page_count));
        }

        [HttpGet("v1/Illustrator/{Illustrator}")]
        public IActionResult BuscaIllustrator(List<string> Illustrator )
        {
            return Ok(_repositorio.BuscaIllustrator(Illustrator));
        }

        [HttpGet("  ")]
        public IActionResult BuscaGenres(List<string> Genres )
        {
            return Ok(_repositorio.BuscaGenres(Genres));
        }

        [HttpGet("v1/listarlivros/OC")]
        public IActionResult OrdenarC()
        {
            return Ok(_repositorio.OrdenarC());
        }

        [HttpGet("v1/listarlivros/OD")]
        public IActionResult OrdenarD()
        {
            return Ok(_repositorio.OrdenarD());
        }

        [HttpGet("v1/listarlivros/frete")]
        public IActionResult Frete()
        {
            return Ok(_repositorio.Frete());
        }
    }

}