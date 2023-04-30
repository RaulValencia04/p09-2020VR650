using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p09_2020VR650.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace p09_2020VR650.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoContext _equipoContext;

        public EquipoController(EquipoContext equipoContext)
        {
            _equipoContext = equipoContext;
        }

        public IActionResult Index()
        {
            var listaDeMarca = (from m in _equipoContext.Marcas
                select m).ToList();
            ViewData["listaDeMarca"] = new SelectList(listaDeMarca, "id_marcas", "nombre_marca");

            var listaDeEstado = (from m in _equipoContext.estados_equipo
                                 select m).ToList();
            ViewData["listaDeEstado"] = new SelectList(listaDeEstado, "id_estados_equipo", "descripcion");


            var listaDeTipo = (from m in _equipoContext.tipo_equipo
                               select m).ToList();
            ViewData["listaDeTipo"] = new SelectList(listaDeTipo, "id_tipo_equipo", "descripcion");
            return View();
        }
        public IActionResult CrearEquipo(Equipos nuevoEquipo)
        {
            _equipoContext.Add(nuevoEquipo);
            _equipoContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}