using Microsoft.AspNetCore.Mvc;
using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Controllers
{
    /*
        Se usa Control + . (punto)
        para poder importar el NAMESPACE
    */
    public class TiposCuentasController: Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            return View();
        }
    }
}
