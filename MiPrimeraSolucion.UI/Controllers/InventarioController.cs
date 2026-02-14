using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
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
        IObtenerRepuestoPorIdLN _obtenerRepuestoPorIdLN;
        IAgregarRepuestoLN _agregarRepuestoLN;
        IEditarRepuestoLN _editarRepuestoLN;
        IEliminarRepuestoLN _eliminarRepuestoLN;

        public InventarioController()
        {
            _obtenerTodoElInventarioLN = new ObtenerTodoElInventarioLN();
            _obtenerRepuestoPorIdLN = new ObtenerRepuestoPorIdLN();
            _agregarRepuestoLN = new AgregarRepuestoLN();
            _editarRepuestoLN = new EditarRepuestoLN();
            _eliminarRepuestoLN = new EliminarRepuestoLN();
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
            InventarioDto elInventario = _obtenerRepuestoPorIdLN.Obtener(id);
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
                int seGuardo = _agregarRepuestoLN.Agregar(elInventarioAGuardar);
                if (seGuardo > 0)
                {

                    return RedirectToAction("ObtenerTodoElInventario");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarRepuesto(int id)
        {
            InventarioDto elInventario = _obtenerRepuestoPorIdLN.Obtener(id);
            return View(elInventario);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarRepuesto(int id, InventarioDto elInventarioAEditar)
        {
            try
            {
                // TODO: Add update logic here
                bool seEdito = _editarRepuestoLN.Editar(elInventarioAEditar);
                if (seEdito)
                {
                    return RedirectToAction("ObtenerTodoElInventario");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult EliminarRepuesto(int id)
        {
            InventarioDto elInventario = _obtenerRepuestoPorIdLN.Obtener(id);
            return View(elInventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarRepuesto(int id, InventarioDto elInventarioParaEliminar)
        {
            try
            {
                // TODO: Add delete logic here
                bool seElimino = _eliminarRepuestoLN.Eliminar(id);
                if (seElimino)
                {
                    return RedirectToAction("ObtenerTodoElInventario");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
