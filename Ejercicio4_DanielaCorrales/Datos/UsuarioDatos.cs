using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class UsuarioDatos
    {
        public async Task<bool> LoginAsync(string correo, string clave)
        {
            bool valido = false;
            try
            {
                string sql = "SELECT 1 FROM login WHERE Correo=@Correo AND Clave=@Clave;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = correo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 120).Value = clave;

                        valido = Convert.ToBoolean(await comando.ExecuteScalarAsync());
                    }
                }

            }
            catch (Exception ex)
            {

            }
            return valido;
        }
    }
}
