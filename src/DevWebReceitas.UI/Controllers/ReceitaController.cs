using System;
using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevWebReceitas.UI.Controllers
{
    public class ReceitaController : BaseController
    {
        private readonly IReceitaService _service;
        private readonly ICategoriaService _categService;

        public ReceitaController(IReceitaService service, ICategoriaService categService)
        {
            _service = service;
            _categService = categService;
        }


        // GET: Receita
        public ActionResult Index(string titulo, string descricao, string modoPreparo, string ingredientes, string categoria)
        {
            var receitas = _service.List(
                new Domain.Filters.ReceitaFilter
                {
                    Titulo = titulo,
                    Descricao = descricao,
                    ModoPreparo = modoPreparo,
                    Ingredientes = ingredientes,
                    TituloCategoria = categoria
                });

            if (HttpExtensions.IsAjaxRequest(Request))
                return PartialView("_Receitas", receitas);

            return View(receitas);
        }

        // GET: Receita/Details/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXX
        public ActionResult Details(Guid codigo)
        {
            var receita = _service.FindByCode(codigo);
            try
            {
                ViewBag.Imagem = _service.FindImageByCode(codigo);
                return View(receita);
            }
            catch 
            {
                return View();
            }
        }

        // GET: Receita/Create
        public ActionResult Create()
        {
            var categorias = _categService.List(new Domain.Filters.CategoriaFilter());
            if (categorias.ToList().Count == 0)
            {
                ModelState.AddModelError("Error", "Para incluir receitas é necessário existirem categorias.");
            }
            ViewBag.Categorias = categorias;
            return View();
        }

        // POST: Receita/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReceitaInsertDto dto)
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

        // GET: Receita/Edit/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXX
        public ActionResult Edit(Guid codigo)
        {
            var receita = _service.FindByCodeEditDto(codigo);

            var categorias = new SelectList(
                _categService.List(new Domain.Filters.CategoriaFilter()),
                "Codigo", "Titulo", receita.Codigo);
            ViewBag.Categorias = categorias;
            try
            {
                ViewBag.Imagem = _service.FindImageByCode(codigo);
                receita.Imagem = ViewBag.Imagem;
                return View(receita);
            }
            catch 
            {
                return View();
            }
        }

        // POST: Receita/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReceitaEditDto receita)
        {
            try
            {
                _service.Update(receita);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Receita/Delete/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXX
        public ActionResult Delete(Guid codigo)
        {
            return Details(codigo);
        }

        // POST: Categoria/Delete/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReceitaDto receita)
        {
            try
            {
                _service.Remove(receita.Codigo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Like(Guid codigo, string redirectTo)
        {
            try
            {
                _service.Like(codigo);

                if (redirectTo.Equals("Details", StringComparison.OrdinalIgnoreCase))
                    return RedirectToAction("Details", new { codigo });

                var receita = _service.FindByCode(codigo);

                if (HttpExtensions.IsAjaxRequest(Request))
                    return PartialView("_LikesDislikes", receita);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Dislike(Guid codigo, string redirectTo)
        {
            try
            {
                _service.Dislike(codigo);
                if (redirectTo.Equals("Details", StringComparison.OrdinalIgnoreCase))
                    return RedirectToAction("Details", new { codigo });

                var receita = _service.FindByCode(codigo);

                if (HttpExtensions.IsAjaxRequest(Request))
                    return PartialView("_LikesDislikes", receita);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}