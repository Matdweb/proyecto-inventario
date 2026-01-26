using MiPrimeraSolucion.Abstracciones.Modelos.Clientes;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult ObtenerTodosLosClientes()
        {
            List<ClienteDto> listaDeClientes = new List<ClienteDto>();
            listaDeClientes.Add(new ClienteDto
            {
                Id = 1,
                Nombre = "Juan",
                PrimerApellido = "Perez",
                SegundoApellido = "Lopez",
                Telefono = "555-1234",
                Correo = "juan@gmial.com",
                FechaDeRegistro = DateTime.Now,
                FechaDeModificacion = DateTime.Now,
                Estado = true
            });
            return View(listaDeClientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Detalles(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult AgregarCliente()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult AgregarCliente(FormCollection collection)
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

        // GET: Cliente/Edit/5
        public ActionResult EditarCliente(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult EditarCliente(int id, FormCollection collection)
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

        // GET: Cliente/Delete/5
        public ActionResult EliminarCliente(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult EliminarCliente(int id, FormCollection collection)
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
