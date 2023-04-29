using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2019MF650_2019SM601_2019AP650.Models;

namespace P2_2019MF650_2019SM601_2019AP650.Controllers
{
    public class casosReportadosController : Controller
    {
        private readonly reportesDBContext _reportesDBContext;

        public casosReportadosController(reportesDBContext reportesDBContext)
        {
            _reportesDBContext = reportesDBContext;
        }
        public IActionResult Index()
        {
            var listaDepartamentos = (from m in _reportesDBContext.departamentos
                                      select m).ToList();

            var listaGeneros = (from m in _reportesDBContext.generos
                                select m).ToList();

            var listaReportes = (from e in _reportesDBContext.casos_reportados
                                   join m in _reportesDBContext.departamentos on e.departamento_id equals m.id_departamento
                                   join n in _reportesDBContext.generos on e.genero_id equals n.id_generos
                                   select new
                                   {
                                       nombre_departamento = m.nombre_departamento,
                                       nombre_genero = n.nombre_genero,
                                       casos_confirmados = e.casos_confirmados,
                                       recuperados = e.recuperados,
                                       fallecidos = e.fallecidos
                                   }).ToList();

            ViewData["listadoReportes"] = listaReportes;
            ViewData["listadoDepartamentos"] = new SelectList(listaDepartamentos, "id_departamento", "nombre_departamento");
            ViewData["listadoGeneros"] = new SelectList(listaGeneros, "id_generos", "nombre_genero");
            return View();
        }
        public IActionResult CrearRegistro(casos_reportados nuevoReporte) 
        {
            _reportesDBContext.Add(nuevoReporte);
            _reportesDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
