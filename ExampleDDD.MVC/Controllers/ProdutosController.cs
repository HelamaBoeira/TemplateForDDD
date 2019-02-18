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
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;
        // GET: Produtos
        public ProdutosController(IProdutoAppService ProdutoApp, IClienteAppService clienteApp)
        {
            _produtoApp = ProdutoApp;
            _clienteApp = clienteApp;
        }

        public ActionResult Index()
        {
            var Produtos = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(Produtos);
        }

        //public ActionResult Especiais()
        //{
        //    var Produtos = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetProdutosEspeciais());
        //    return View(Produtos);
        //}

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoApp.GetById(id));
            return View(ProdutoViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {

            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel Produto)
        {
            if (ModelState.IsValid)
            {
                var ProdutoDomain = Mapper.Map<ProdutoViewModel, Produto>(Produto);
                _produtoApp.Add(ProdutoDomain);
                return RedirectToAction("Index");                  
            }

            return View(Produto);
            
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoApp.GetById(id));
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", ProdutoViewModel.ClienteId);
            return View(ProdutoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel Produto)
        {
            if (ModelState.IsValid)
            {
                var ProdutoDomain = Mapper.Map<ProdutoViewModel, Produto>(Produto);
                _produtoApp.Update(ProdutoDomain);
                return RedirectToAction("Index");
            }

            return View(Produto);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var ProdutoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoApp.GetById(id));
            return View(ProdutoViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _produtoApp.Remove(_produtoApp.GetById(id));

            return RedirectToAction("Index");
        }
    }
}