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

        public IActionResult Editar(int id)
        {
            Funcionario? funcionario = funcRepository.BuscarPorId(id);
            ViewBag.TipoTela = "Editar";
            return View("~/Views/Funcionario/CriarEditar.cshtml", funcionario);
        }

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            funcRepository.Adicionar(funcionario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Funcionario funcionario)
        {
            funcRepository.Atualizar(funcionario);
            return RedirectToAction("Index");
        }
    }
}
