using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ILogger<ContatoController> _logger;
        private readonly AgendaContext _context;

        public ContatoController(ILogger<ContatoController> logger, AgendaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }







    }
}