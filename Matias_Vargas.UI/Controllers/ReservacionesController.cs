using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones.AgregarReservacionLN;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.LogicaDeNegocio.Reservaciones.AgregarReservacion;
using Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerReservaPorId;
using Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerTodasLasReservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matias_Vargas.UI.Controllers
{
    public class ReservacionesController : Controller
    {
        IObtenerTodasLasReservasLN _obtenerTodasLasReservasLN;
        IObtenerReservaPorIdLN _obtenerReservaPorIdLN;
        IObtenerReservasPorIdHabitacionLN _obtenerReservasPorIdHabitacionLN;
        IAgregarReservacionLN _agregarReservacionLN;

        public ReservacionesController()
        {
            _obtenerReservaPorIdLN = new ObtenerReservaPorIdLN();
            _obtenerTodasLasReservasLN = new ObtenerTodasLasReservasLN();
            _obtenerReservasPorIdHabitacionLN = new ObtenerReservasPorIdHabitacionLN();
            _agregarReservacionLN = new AgregarReservacionLN();
        }

        // GET: Reservaciones
        public ActionResult ObtenerTodasLasReservaciones()
        {
            List<ReservacionesconHabitacionDto> listaReservaciones = _obtenerTodasLasReservasLN.Obtener();
            return View(listaReservaciones);
        }

        // GET: Reservaciones/Details/5
        public ActionResult ObtenerReservacionPorId(int id)
        {
            ReservacionesconHabitacionDto laReserva = _obtenerReservaPorIdLN.ObtenerPorId(id);
            if(laReserva == null)
            {
                TempData["mensaje"] = $"Estimado usuario, no se ha encontrado la reservación, favor realice una";
                return RedirectToAction("ObtenerTodasLasReservaciones");
            }
            else
            {
                return View(laReserva);
            }
        }

        // GET: Reservaciones/Details/5
        public ActionResult ObtenerReservacionesPorIdHabitacion(int idHabitacion)
        {
            int i = idHabitacion;
            List<ReservacionesDto> listaReservaciones = _obtenerReservasPorIdHabitacionLN.Obtener(idHabitacion);
            if (listaReservaciones.Count == 0)
            {
                TempData["mensaje"] = $"Estimado usuario, no se han encontrado reservaciones para la habitacion selecionada, favor realice una";
                return RedirectToAction("ObtenerTodasLasReservaciones");
            }
            else
            {
                return View(listaReservaciones);
            }
        }

        // GET: Reservaciones/Create
        public ActionResult AgregarReservacion()
        {
            return View();
        }

        // POST: Reservaciones/Create
        [HttpPost]
        public ActionResult AgregarReservacion(ReservacionesDto laReservacionAgregar, int idHabitacion)
        {
            try
            {
                laReservacionAgregar.FechaDeRegistro = DateTime.Now;
                laReservacionAgregar.MontoTotal = 0;
                laReservacionAgregar.IdHabitacion = idHabitacion;

                int seAgrego = _agregarReservacionLN.Agregar(laReservacionAgregar);
                if (seAgrego > 0)
                {
                    return RedirectToAction("ObtenerTodasLasReservaciones");
                }
                else
                {
                    TempData["mensaje"] = $"Estimado usuario, no se ha podido agregar la reservación, favor intente nuevamente";
                    return RedirectToAction("ObtenerTodasLasReservaciones");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Reservaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservaciones/Delete/5
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
