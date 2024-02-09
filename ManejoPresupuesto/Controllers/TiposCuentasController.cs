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

        public async Task<IActionResult> Index()
        {
            var usuarioId = 1;
            var tiposCuentas = await reposotioTiposCuentas.Obtener(usuarioId);

            return View(tiposCuentas);
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

            var yaExisteTipoCuenta = await reposotioTiposCuentas.Existe(tipoCuenta.Nombre, tipoCuenta.UsuarioId);

            if (yaExisteTipoCuenta)
            {
                ModelState.AddModelError(nameof(tipoCuenta.Nombre), $"El nombre: '{tipoCuenta.Nombre}', ya existe. Intente con otro...");

                return View(tipoCuenta);
            }

            await reposotioTiposCuentas.Crear(tipoCuenta);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> VerificarExisteTipoCuenta(string nombre)
        {
            var usuarioId = 1;
            var yaExisteTipoCuenta = await reposotioTiposCuentas.Existe(nombre, usuarioId);

            if (yaExisteTipoCuenta)
            {
                return Json($"El nombre: {nombre}, ya existe");
            }

            return Json(true);
        }

    }
}
