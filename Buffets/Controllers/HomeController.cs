using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffets.Models;
using Buffets.Models.Buffet.Cliente;
using Buffets.viewModels.Home;

namespace Buffets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Logo()
        {
            return View();
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }
        
        public IActionResult RecuperacaoConta()
        {
            return View();
        }
        public IActionResult TermoUso()
        {
            return View();
        }
        public IActionResult Clientes()
        {
            /*Não está funcionando
            var clienteService = new ClienteService();
            
            
            var listaDeClientes:List<ClienteEntity> = clienteService.obterClientes();

            var viewModels = new ClientesViewModels();
            foreach (ClienteEntity clienteEntity in listaDeClientes)
            {
                viewModels.Clientes.Add(new Cliente
                {
                    Nome = clienteEntity.Nome,
                    DataDeNacimento = clienteEntity.DataDeNascimento.ToShortDateString()
                });
            }
           */ 
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult PainelUsuario()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}