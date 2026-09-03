using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC2
{
    internal class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=umg_didactica");
            try
            {
                conn.Open();
            } 
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);

            }
            return conn;
        }
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
    }
}
