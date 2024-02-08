using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios
{
    public interface IReposotioTiposCuentas
    {
        Task Crear(TipoCuenta tipoCuenta);
    }

    public class RepositorioTiposCuentas: IReposotioTiposCuentas
    {
        private readonly string connectionString;

        // Atajo para crear CONSTRUCTOR: ctor
        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);

            // SELECT SCOPE_IDENTITY(); : Nos arroja el ID del último registro creado
            var id = await connection.QuerySingleAsync<int>(
                $@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden) VALUES (@Nombre, @UsuarioId, 0);
                SELECT SCOPE_IDENTITY();", tipoCuenta
            );

            tipoCuenta.Id = id;
        }

    }
}
