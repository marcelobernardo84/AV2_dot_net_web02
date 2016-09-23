using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Context;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class FornecedorsController : Controller
    {
        private ProjetoModeloContext db = new ProjetoModeloContext();

        // GET: Fornecedors
        public ActionResult Index()
        {
            var fornecedors = db.Fornecedors.Include(f => f.Endereco).Include(f => f.Produto);
            return View(fornecedors.ToList());
        }

        // GET: Fornecedors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // GET: Fornecedors/Create
        public ActionResult Create()
        {
            ViewBag.EnderecoId = new SelectList(db.Enderecos, "EnderecoId", "logradouro");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Nome");
            return View();
        }

        // POST: Fornecedors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FornecedorId,cnpj,razaoSocial,inscricaoMunicipal,receitaBruta,ProdutoId,EnderecoId")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Fornecedors.Add(fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EnderecoId = new SelectList(db.Enderecos, "EnderecoId", "logradouro", fornecedor.EnderecoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Nome", fornecedor.ProdutoId);
            return View(fornecedor);
        }

        // GET: Fornecedors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            ViewBag.EnderecoId = new SelectList(db.Enderecos, "EnderecoId", "logradouro", fornecedor.EnderecoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Nome", fornecedor.ProdutoId);
            return View(fornecedor);
        }

        // POST: Fornecedors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FornecedorId,cnpj,razaoSocial,inscricaoMunicipal,receitaBruta,ProdutoId,EnderecoId")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EnderecoId = new SelectList(db.Enderecos, "EnderecoId", "logradouro", fornecedor.EnderecoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Nome", fornecedor.ProdutoId);
            return View(fornecedor);
        }

        // GET: Fornecedors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fornecedor fornecedor = db.Fornecedors.Find(id);
            db.Fornecedors.Remove(fornecedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
