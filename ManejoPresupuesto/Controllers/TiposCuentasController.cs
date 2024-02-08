using Microsoft.AspNetCore.Mvc;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace ManejoPresupuesto.Controllers
{
    /*
        Se usa Control + . (punto)
        para poder importar el NAMESPACE
    */
    public class TiposCuentasController: Controller
    {
        private readonly string connectionString;
        public TiposCuentasController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //public IActionResult Crear()
        //{
        //    return View();
        //}

        //[HttpPost]


        public IActionResult Crear()
        {
            using ( var connection = new SqlConnection(connectionString) )
            {
                var query = connection.Query("SELECT 1").FirstOrDefault();
            }

            return View();
        }
    }
}
