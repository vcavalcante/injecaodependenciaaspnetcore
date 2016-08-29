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
        public ClienteRepositorio _clienteRepositorio { get; set; }
        public ClienteController(ClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            //var pedidoRepositorio = new ClienteRepositorio();
            var clientes = _clienteRepositorio.ObterTodos();
            return View(clientes);
        }
    }
}




