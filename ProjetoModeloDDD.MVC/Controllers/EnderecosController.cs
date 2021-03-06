﻿using AutoMapper;
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
    public class EnderecosController : Controller
    {

        private readonly IEnderecoAppService _enderecoApp;

        public EnderecosController(IEnderecoAppService enderecoApp)
        {
            _enderecoApp = enderecoApp;
        }

        // GET: Enderecos
        public ActionResult Index()
        {
            var enderecoViewModel = Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoApp.GetAll());
            return View(enderecoViewModel);
        }

        // GET: Enderecos/Details/5
        public ActionResult Details(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // GET: Enderecos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enderecos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnderecoViewModel endereco)
        {
            var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
            _enderecoApp.Add(enderecoDomain);

            return RedirectToAction("Index");
        }

        // GET: Enderecos/Edit/5
        public ActionResult Edit(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // POST: Enderecos/Edit/5
        [HttpPost]
        public ActionResult Edit(EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Update(enderecoDomain);

                return RedirectToAction("Index");
            }

            return View(endereco);
        }

        // GET: Enderecos/Delete/5
        public ActionResult Delete(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);
            return View(enderecoViewModel);
        }

        // POST: Enderecos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            _enderecoApp.Remove(endereco);
            return RedirectToAction("Index");
        }

    }
}
