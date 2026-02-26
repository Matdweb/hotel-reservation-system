using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.AgregarHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.EditarHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.ObtenerTodasLasHabitaciones;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.LogicaDeNegocio.Habitaciones.AgregarHabitacion;
using Matias_Vargas.LogicaDeNegocio.Habitaciones.EditarHabitacion;
using Matias_Vargas.LogicaDeNegocio.Habitaciones.ObtenerTodasLasHabitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matias_Vargas.UI.Controllers
{
    public class HabitacionesController : Controller
    {
        IObtenerTodasLasHabitacionesLN _obtenerTodasLasHabitacionesLN;
        IAgregarHabitacionLN _agregarHabitacionLN;
        IEditarHabitacionLN _editarHabitacionAD;

        public HabitacionesController()
        {
            _obtenerTodasLasHabitacionesLN = new ObtenerTodasLasHabitacionesLN();
            _agregarHabitacionLN = new AgregarHabitacionLN();
            _editarHabitacionAD = new EditarHabitacionLN();
        }

        // GET: Habitaciones
        public ActionResult ObtenerTodasLasHabitaciones()
        {
            List<HabitacionesDto> habitaciones = _obtenerTodasLasHabitacionesLN.Obtener();
            return View(habitaciones);
        }

        public ActionResult ObtenerTodasLasHabitacionesActivas()
        {
            List<HabitacionesDto> habitaciones = _obtenerTodasLasHabitacionesLN.ObtenerActivas();
            return View(habitaciones);
        }

        // GET: Habitaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Habitaciones/Create
        public ActionResult AgregarHabitacion()
        {
            return View();
        }

        // POST: Habitaciones/Create
        [HttpPost]
        public ActionResult AgregarHabitacion(HabitacionesDto laHabitacionAgregar)
        {
            try
            {
                int seAgrego = _agregarHabitacionLN.Agregar(laHabitacionAgregar);
                if(seAgrego > 0)
                {
                    return RedirectToAction("ObtenerTodasLasHabitaciones");

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

        // GET: Habitaciones/Edit/5
        public ActionResult EditarHabitacion(int id)
        {
            HabitacionesDto habitacionAEditar = _obtenerTodasLasHabitacionesLN.Obtener().Where(h => h.Id == id).FirstOrDefault();
            return View(habitacionAEditar);
        }

        // POST: Habitaciones/Edit/5
        [HttpPost]
        public ActionResult EditarHabitacion(int id, HabitacionesDto laHabitacionAEditar)
        {
            try
            {
                // TODO: Add update logic here
                bool seEdito = _editarHabitacionAD.Editar(laHabitacionAEditar);
                if (seEdito)
                {
                    return RedirectToAction("ObtenerTodasLasHabitaciones");
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

        // GET: Habitaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habitaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
