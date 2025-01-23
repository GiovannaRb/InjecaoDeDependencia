using Injeção_de_dependência.Models;

namespace Injeção_de_dependência.Interfaces
{
    public interface IDInterface
    {
        public void Cadastrar(dadosModel dados);
        public void Editar(dadosModel dados);
        public void Deletar(int id);
    }
}
