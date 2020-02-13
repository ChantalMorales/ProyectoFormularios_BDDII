using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form106 : Form
    {

        public static decimal total;
        Validacion v = new Validacion();
        private void ObtenerId()
        {
            lbId4.Text = Form102.id;
        }
        public Form106()
        {
            InitializeComponent();
        }

        private void Form106_Load(object sender, EventArgs e)
        {
            ObtenerId();
            DataSet102ATableAdapters.ContribuyenteTableAdapter ta = new DataSet102ATableAdapters.ContribuyenteTableAdapter();
            DataSet102A.ContribuyenteDataTable dt = ta.GetDatosContr(Convert.ToInt32(lbId4.Text));
            DataSet102A.ContribuyenteRow row = (DataSet102A.ContribuyenteRow)dt.Rows[0];
            txtRazon.Text = (row.Nombre.ToString());
            txtRuc.Text = (row.RUC.ToString());
            txtImpuesto.Text = (row.Saldo_Tributario.ToString());
            txtCodImp.Text = row.id_contribuyente.ToString();


        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtMultas_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtDescp_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            total = decimal.Parse(txtImpuesto.Text) + decimal.Parse(txtInteres.Text) + decimal.Parse(txtMultas.Text);
            txtTotal.Text = total.ToString();

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DataSet102ATableAdapters.Form_106TableAdapter ta = new DataSet102ATableAdapters.Form_106TableAdapter();


            try
            {
                ta.InsertF106(txtCodDoc.Text.Trim(), txtMes.Text.Trim(), txtAño.Text.Trim(), total, txtDescp.Text.Trim(), Convert.ToInt32(lbId4.Text));
                MessageBox.Show("Pago generado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
