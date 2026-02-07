using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class InventarioController : Controller
    {
        IObtenerTodoElInventarioLN _obtenerTodoElInventarioLN;

        public InventarioController()
        {
            _obtenerTodoElInventarioLN = new ObtenerTodoElInventarioLN();
        }

        // GET: Inventario
        public ActionResult ObtenerTodoElInventario()
        {
            List<InventarioDto> laListaDelInventario = _obtenerTodoElInventarioLN.Obtener();

            return View(laListaDelInventario);
        }

        // GET: Inventario/Details/5
        public ActionResult Detalles(int id)
        {
            InventarioDto elInventario = new InventarioDto
            {
                Id = id,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            };
            return View(elInventario);
        }

        // GET: Inventario/Create
        public ActionResult AgregarRepuesto()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult AgregarRepuesto(InventarioDto elInventarioAGuardar)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("ObtenerTodoElInventario");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarRepuesto(int id)
        {
            InventarioDto elInventario = new InventarioDto
            {
                Id = id,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            };
            return View(elInventario);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarRepuesto(int id, InventarioDto elInventarioAEditar)
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
        public ActionResult EliminarRepuesto(int id)
        {
            InventarioDto elInventario = new InventarioDto
            {
                Id = id,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            };
            return View(elInventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarRepuesto(int id, InventarioDto elInventarioParaEliminar)
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
