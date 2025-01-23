using Injeção_de_dependência.Interfaces;
using Injeção_de_dependência.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace Injeção_de_dependência.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IDController : ControllerBase
    {
        public readonly IDInterface _repository;

        public IDController(IDInterface repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public void Cadastrar(dadosModel dados)
        {
            _repository.Cadastrar(dados);
        }

        [HttpPost]
        public void Editar(dadosModel dados)
        {
            _repository.Editar(dados);
        }

        [HttpDelete]
        public void Deletar(int id)
        {
            _repository.Deletar(id);
        }
    }
}
