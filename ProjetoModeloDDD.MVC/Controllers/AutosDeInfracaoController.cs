using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class AutosDeInfracaoController : Controller
    {

        private readonly IAutoDeInfracaoAppService _autoDeInfracaoApp;

        public AutosDeInfracaoController(IAutoDeInfracaoAppService autoDeInfracaoApp)
        {
            _autoDeInfracaoApp = autoDeInfracaoApp;
        }

        // GET: AutosDeInfracao
        public ActionResult Index()
        {
            var autoDeInfracaoViewModel = Mapper.Map<IEnumerable<AutoDeInfracao>, IEnumerable<AutoDeInfracaoViewModel>>(_autoDeInfracaoApp.GetAll());
            return View(autoDeInfracaoViewModel);
        }

        // GET: AutosDeInfracao/Details/5
        public ActionResult Details(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // GET: AutosDeInfracao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutosDeInfracao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AutoDeInfracaoViewModel autoDeInfracao)
        {
            var autoDeInfracaoDomain = Mapper.Map<AutoDeInfracaoViewModel, AutoDeInfracao>(autoDeInfracao);
            _autoDeInfracaoApp.Add(autoDeInfracaoDomain);

            return RedirectToAction("Index");
        }

        // GET: AutosDeInfracao/Edit/5
        public ActionResult Edit(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // POST: AutosDeInfracao/Edit/5
        [HttpPost]
        public ActionResult Edit(AutoDeInfracaoViewModel autoDeInfracao)
        {
            if (ModelState.IsValid)
            {
                var autoDeInfracaoDomain = Mapper.Map<AutoDeInfracaoViewModel, AutoDeInfracao>(autoDeInfracao);
                _autoDeInfracaoApp.Update(autoDeInfracaoDomain);

                return RedirectToAction("Index");
            }

            return View(autoDeInfracao);
        }

        // GET: AutosDeInfracao/Delete/5
        public ActionResult Delete(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            var autoDeInfracaoViewModel = Mapper.Map<AutoDeInfracao, AutoDeInfracaoViewModel>(autoDeInfracao);
            return View(autoDeInfracaoViewModel);
        }

        // POST: AutosDeInfracao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var autoDeInfracao = _autoDeInfracaoApp.GetById(id);
            _autoDeInfracaoApp.Remove(autoDeInfracao);
            return RedirectToAction("Index");
        }

    }
}
