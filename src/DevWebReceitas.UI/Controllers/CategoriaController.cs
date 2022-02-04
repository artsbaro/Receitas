using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

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
            //var categorias = GetCategorias().Result;
            var categorias =
            _service.List(
                new Domain.Filters.CategoriaFilter
                {
                    Titulo = titulo,
                    Descricao = descricao
                });

            if (HttpExtensions.IsAjaxRequest(Request))
                return PartialView("_Categorias", categorias);
            return View(categorias);
        }

        // GET: Categoria/Details/XXXXXXX-XXXXXXX-XXXXXXX-XXXXXXXXX
        public ActionResult Details(Guid codigo)
        {
            var categoria = Task.Run(() => _service.FindByCode(codigo));
            return View(categoria.Result);
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
            return Details(codigo);
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
            return Details(codigo);
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

        /// <summary>
        /// Exemplo de paralelismo 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<CategoriaDto> GetCategorias()
        {
            ConcurrentBag<CategoriaDto> list = new ConcurrentBag<CategoriaDto>();
            var tasks = new Task[]
            {
                Task.Run(() => { list.Add(GetCategoria("8AF4268C-C404-4728-A393-B61878A0015C")); }),
                Task.Run(() => { list.Add(GetCategoria("DD6C149F-CDB7-47A2-8E8C-9B5259499A0A")); }),
                Task.Run(() => { list.Add(GetCategoria("96E70766-724A-48BA-A67C-8DBB295C9473")); }),
                Task.Run(() => { list.Add(GetCategoria("54D3CEFA-ADA6-4188-BF9C-68BB2365C66B")); })
            };

            Task.WaitAll(tasks);
            return list;
        }
        private CategoriaDto GetCategoria(string code)
        {
            var client = new RestClient($"http://localhost:52150/api/Categoria/{code}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = client.Execute<CategoriaDto>(request);
            return response.Data;
        }
    }
}