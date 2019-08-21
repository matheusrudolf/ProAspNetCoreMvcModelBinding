using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcModelBinding.Models;
using ProAspNetCoreMvcModelBinding.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(int id)
        {
            return View("Index", repository[id]);
        }

        public ViewResult Index2(int id)
        {
            return View("Index", repository[id] ?? repository.Pessoa.First());
        }

        public IActionResult Index3(int? id)
        {
            Pessoa pessoa;
            if (id.HasValue && (pessoa = repository[id.Value]) != null)
            {
                return View(pessoa);
            }
            else
            {
                return NotFound();
            }
        }
        public ViewResult Cadastro()
        {
            return View("Cadastro", new Pessoa());
        }

        [HttpPost]
        public ViewResult Cadastro(Pessoa pessoa)
        {
            return View("Index", pessoa);
        }

        public ViewResult EnderecoBasico(EnderecoResumido endereco)
        {
            return View("EnderecoBasico", endereco);
        }
        public ViewResult EnderecoBasico2([Bind(Prefix = nameof(Pessoa.EnderecoCasa))] EnderecoResumido endereco)
        {
            return View("EnderecoBasico", endereco);
        }
        public ViewResult EnderecoBasico3([Bind(nameof(EnderecoResumido.Cidade), Prefix = nameof(Pessoa.EnderecoCasa))] EnderecoResumido endereco)
        {
            return View("EnderecoBasico", endereco);
        }
        public ViewResult Nomes(string[] nomes)
        {
            return View("Nomes", nomes ?? new string[0]);
        }
    }
}
