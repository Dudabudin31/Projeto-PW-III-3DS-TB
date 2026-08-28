using Microsoft.AspNetCore.Mvc;
using Projeto_Cadastro_MVC_3DSTB.Models;
using Projeto_Cadastro_MVC_3DSTB.Repository;

namespace Projeto_Cadastro_MVC_3DSTB.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository funcRepository;

        public FuncionarioController(IFuncionarioRepository rep)
        {
            funcRepository = rep;
        }

        public IActionResult Index()
        {
            List<Funcionario> listaFuncionarios = funcRepository.BuscarTodos();
            return View(listaFuncionarios);
        }

        public IActionResult Criar()
        {
            ViewBag.TipoTela = "Criar";
            return View("~/Views/Funcionario/CriarEditar.cshtml");
        }

        public IActionResult Editar()
        {
            ViewBag.TipoTela = "Editar";
            return View("~/Views/Funcionario/CriarEditar.cshtml");
        }
    }
}
