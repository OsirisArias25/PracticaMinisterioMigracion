using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica.Models;
using Practica.Paises;
using Practica.Procesos;
using System.Data;

namespace Practica.Controllers
{
    public class JugadoresController : Controller
    {

        // Lista de Jugadores y Equipos
        public IActionResult Index()
        {
            Operaciones operaciones = new Operaciones();
            return View(operaciones.Listados());
        }


        /*************************************************
         Vista de Crear Jugador y Metodo para agregarlo a la base de datos
         *************************************************/

        [HttpGet]
        public IActionResult CrearJugador() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarJugador(Jugadores data) 
        {
            Operaciones operaciones = new Operaciones();
            operaciones.AgregarJugadorNuevo(data);
            return RedirectToAction("Index");
        }

        /*************************************************
         Vista de Crear Equipo y Metodo para agregarlo a la base de datos
         *************************************************/

        [HttpGet]
        public IActionResult CrearEquipo() 
        {
            OperacionesPaises operacionesPaises = new OperacionesPaises();
            var listado_paises = operacionesPaises.ListadoDePaises();
            ViewData["Paises"] = listado_paises;
            return View(); 
        }

        [HttpPost]
        public IActionResult AgregarEquipo(Equipo data) 
        {
            Operaciones operaciones = new Operaciones();
            operaciones.AgregarEquipoNuevo(data);
            return RedirectToAction("Index");
        }

    }
}
