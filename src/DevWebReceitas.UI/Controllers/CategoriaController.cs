using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevWebReceitas.UI.Controllers
{
    public class CategoriaController : BaseController
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        // GET: Categoria
        public ActionResult Index(string titulo = null, string descricao = null)
        {
            var categorias = _service.List(new Domain.Filters.CategoriaFilter { Titulo = titulo, Descricao = descricao });

            if (HttpExtensions.IsAjaxRequest(Request))
                return PartialView("_Categorias", categorias);

            return View(categorias);
        }

        // GET: Categoria/Details/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Details(Guid codigo)
        {
            var categoria = _service.FindByCode(codigo);
            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaInsertDto dto)
        {
            try
            {
                _service.Create(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Edit(Guid codigo)
        {
            var categoria = _service.FindByCode(codigo);
            return View(categoria);
        }

        // POST: Categoria/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaDto dto)
        {
            try
            {
                _service.Update(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Delete(Guid codigo)
        {
            var categoria = _service.FindByCode(codigo);
            return View(categoria);
        }

        // POST: Categoria/Delete/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(CategoriaDto dto)
        {
            try
            {
                _service.Remove(dto.Codigo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}