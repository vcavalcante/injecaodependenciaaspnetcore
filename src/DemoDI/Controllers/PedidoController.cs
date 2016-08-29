using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoDI.Data;

namespace DemoDI.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            var clienteRepositorio = new ClienteRepositorio();
            var clientes = clienteRepositorio.ObterTodos();
            return View(clientes);
        }
    }
}


