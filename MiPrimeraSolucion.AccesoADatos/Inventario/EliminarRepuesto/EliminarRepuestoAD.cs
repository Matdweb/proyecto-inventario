using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.EliminarRepuesto
{
    public class EliminarRepuestoAD : IEliminarRepuestoAD
    {
        Contexto _elContexto;

        public EliminarRepuestoAD()
        {
            _elContexto = new Contexto();
        }

        public int EliminarRepuesto(int idRepuesto)
        {
            InventarioEntidad elRepuesto = _elContexto.InventarioEntidad.Find(idRepuesto);
            if (elRepuesto != null)
            {
                _elContexto.InventarioEntidad.Remove(elRepuesto);
                return _elContexto.SaveChanges();
            }
            return 0;
        }
    }
}
