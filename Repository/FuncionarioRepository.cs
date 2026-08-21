using Projeto_Cadastro_MVC_3DSTB.Data;
using Projeto_Cadastro_MVC_3DSTB.Models;

namespace Projeto_Cadastro_MVC_3DSTB.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DatabaseContext dbContext;
        public FuncionarioRepository(DatabaseContext context)
        {
            dbContext = context;
        }

        public List<Funcionario> BuscarTodos()
        {
            return dbContext.Funcionarios.ToList();
        }
    }
}
