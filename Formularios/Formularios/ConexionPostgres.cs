using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Formularios
{
    public class ConexionPostgres
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password=12345; Database = postgres");
        
        public void Conectar()
        {
            conn.Open();
            
        }
        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("Cerrado");
        }
    }

}
