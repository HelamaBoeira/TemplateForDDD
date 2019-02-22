using AutoMapper;
using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using ExampleDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        // GET: Clientes
        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        public ActionResult Index()
        {
            var clientes = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
            return View(clientes);
        }

        public ActionResult Especiais()
        {
            var clientes = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetClientesEspeciais());
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.GetById(id));
            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                var result = _clienteApp.Add(clienteDomain);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.ErrorsMessage)
                    ModelState.AddModelError("", error);

            }
            return View(cliente);
            
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.GetById(id));
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                var result = _clienteApp.Update(clienteDomain);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.ErrorsMessage)
                    ModelState.AddModelError("", error);
            }

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.GetById(id));
            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _clienteApp.Remove(_clienteApp.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
