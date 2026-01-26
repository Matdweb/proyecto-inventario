using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class InventarioController : Controller
    {
        // GET: Inventario
        public ActionResult ObtenerTodoElInventario()
        {
            List<InventarioDto> laListaDelInventario = new List<InventarioDto>();
            laListaDelInventario.Add(new InventarioDto
            {
                NombreDelRepuesto = "Bujias",
                MarcaDelRepuesto = "Chevrolet",
                Anio = 2020,
                Canitdad = 50,
            });
            return View(laListaDelInventario);
        }

        // GET: Inventario/Details/5
        public ActionResult Detalles(int id)
        {
            return View();
        }

        // GET: Inventario/Create
        public ActionResult AgregarRepuesto()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult AgregarRepuesto(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult Eliminar(int id)
        {
            return View();
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
