using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Formularios
{
    public partial class Login : Form
    {
        ConexionPostgres conectarse = new ConexionPostgres();
        NpgsqlConnection conn;


        public Login()
        {
            InitializeComponent();
            conn = new NpgsqlConnection("Server=localhost; User Id= postgres; Password=12345; Database= postgres");

        }    

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                ///conectarse.Conectar();

                conn.Open();
                NpgsqlCommand adp = new NpgsqlCommand("select * from public.users where user_name='" + txtName.Text + "'and user_pass='" + txtPasswd.Text + "'", conn);
                NpgsqlDataReader dt = adp.ExecuteReader();
                
                if (dt.Read())
                {
                    this.Hide();
                    Principal fr = new Principal();
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor verifica tu usuario y contraseña");
                    conn.Close();
                }
            }catch (Exception error)
            {
                MessageBox.Show("Error" + error);
                conn.Close();
            }
            
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
