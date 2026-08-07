using Microsoft.EntityFrameworkCore;
using Projeto_Cadastro_MVC_3DSTB.Models;

namespace Projeto_Cadastro_MVC_3DSTB.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(
                DbContextOptions<DatabaseContext> options
            ) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
