using Projeto_Cadastro_MVC_3DSTB.Models;

namespace Projeto_Cadastro_MVC_3DSTB.Repository
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> BuscarTodos();
        Funcionario Adicionar(Funcionario funcionario);
        Funcionario? BuscarPorId(int id);
        void Atualizar(Funcionario funcionario);
    }
}
