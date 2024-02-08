using Microsoft.AspNetCore.Mvc;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using ManejoPresupuesto.Servicios;

namespace ManejoPresupuesto.Controllers
{
    /*
        Se usa Control + . (punto)
        para poder importar el NAMESPACE
    */
    public class TiposCuentasController: Controller
    {
        private readonly IReposotioTiposCuentas reposotioTiposCuentas;

        public TiposCuentasController(IReposotioTiposCuentas reposotioTiposCuentas)
        {
            this.reposotioTiposCuentas = reposotioTiposCuentas;
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            tipoCuenta.UsuarioId = 1;
            await reposotioTiposCuentas.Crear(tipoCuenta);

            return View();
        }
    }
}
