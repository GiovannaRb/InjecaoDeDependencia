using Injeção_de_dependência.Interfaces;
using Injeção_de_dependência.Models;

namespace Injeção_de_dependência.Repositories
{
    public class IDRepository : IDInterface
    {
        public void Cadastrar(dadosModel dados)
        {
            //Metodo para cadastrar no banco
        }

        public void Editar(dadosModel dados)
        {
            //Metodo para Editar no banco
        }

        public void Deletar(int id)
        {
            //Metodo para Deletar no banco
        }
    }
}
