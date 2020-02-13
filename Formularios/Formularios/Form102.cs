using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Formularios
{
    public partial class Form102 : Form
    {

        Validacion v = new Validacion();
        public Form102()
        {
            InitializeComponent();
        }
        public static String id;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRazonSocial.Text)|| string.IsNullOrEmpty(txtRUC.Text))
            {
                MessageBox.Show("por favor ingrese la razón Social y el RUC");
                return;
            }
            
            DataSet102ATableAdapters.ContribuyenteTableAdapter ta = new DataSet102ATableAdapters.ContribuyenteTableAdapter();
            ta.InsertContribuyente(txtRUC.Text.Trim(), txtRazonSocial.Text.Trim());

        }

        private void IngresosTotales()
        {
            SqlConnection sqlcmd = new SqlConnection(@"Data Source= CHANTALM;Initial Catalog=For_102A;Integrated Security=True");
            try
            {
                if (sqlcmd.State == ConnectionState.Closed)
                    sqlcmd.Open();

                String query = "SELECT id_contribuyente from Contribuyente where RUC=@ruc";
                SqlCommand sqlcon = new SqlCommand(query, sqlcmd);
                sqlcon.Parameters.AddWithValue("@ruc", txtRUC.Text);
                SqlDataReader register = sqlcon.ExecuteReader();

                if (register.Read())
                {
                    lbId.Text = register["id_contribuyente"].ToString();
                }

                sqlcmd.Close();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRazonSocial.Text) || string.IsNullOrEmpty(txtRUC.Text))
            {
                MessageBox.Show("por favor ingrese la razón Social y el RUC");
                return;
            }
            IngresosTotales();
            DataSet102ATableAdapters.IngresosTableAdapter ta = new DataSet102ATableAdapters.IngresosTableAdapter();
            
            decimal total;
            total = decimal.Parse(textBox3.Text) + decimal.Parse(textBox4.Text)+ decimal.Parse(textBox5.Text)+ decimal.Parse(textBox6.Text)+decimal.Parse(textBox7.Text)+ decimal.Parse(textBox8.Text)+ decimal.Parse(textBox9.Text)+ decimal.Parse(textBox10.Text)+ decimal.Parse(textBox11.Text);
            txtTotal.Text = total.ToString();
            try
            {
                ta.InsertIngresos(total, Convert.ToInt32(lbId.Text));

            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void Form102_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = lbId.Text;
            FormGastos102A frm = new FormGastos102A();
            frm.ShowDialog();
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
        
        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
