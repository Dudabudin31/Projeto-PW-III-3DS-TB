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

        public Funcionario Adicionar(Funcionario funcionario)
        {
            dbContext.Funcionarios.Add(funcionario);
            dbContext.SaveChanges();
            return funcionario;
        }

        public Funcionario? BuscarPorId(int id)
        {
            return dbContext.Funcionarios.FirstOrDefault(f => f.Id == id);
        }

        public void Atualizar(Funcionario funcionario)
        {
            Funcionario? func = BuscarPorId(funcionario.Id);

            if (func == null)
            {
                throw new Exception("Houve um erro na atualização!");
            }

            func.Nome = funcionario.Nome;
            func.CPF = funcionario.CPF;
            func.Funcao = funcionario.Funcao;
            func.Salario = funcionario.Salario;

            dbContext.Funcionarios.Update(func);
            dbContext.SaveChanges();
        }
    }
}
