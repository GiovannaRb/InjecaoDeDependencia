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
        public readonly IDInterface _interfaceid;

        public IDController(IDInterface itface)
        {
            _interfaceid = itface;
        }

        [HttpGet]
        public void Cadastrar(dadosModel dados)
        {
            _interfaceid.Cadastrar(dados);
        }

        [HttpPost]
        public void Editar(dadosModel dados)
        {
            _interfaceid.Editar(dados);
        }

        [HttpDelete]
        public void Deletar(int id)
        {
            _interfaceid.Deletar(id);
        }
    }
}
