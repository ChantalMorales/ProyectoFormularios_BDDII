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
    public partial class FormGastos102A : Form
    {
        Validacion v = new Validacion();
        public FormGastos102A()
        {
            InitializeComponent();
        }

        private void ObtenerId()
        {
            lbId2.Text = Form102.id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerId();
            DataSet102ATableAdapters.GastosTableAdapter ta = new DataSet102ATableAdapters.GastosTableAdapter();

            decimal total;
            total = decimal.Parse(textBox1.Text) + decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text) + decimal.Parse(textBox4.Text) + decimal.Parse(textBox5.Text) + decimal.Parse(textBox6.Text) + decimal.Parse(textBox7.Text) + decimal.Parse(textBox8.Text) + decimal.Parse(textBox9.Text)+ decimal.Parse(textBox10.Text)+ decimal.Parse(textBox11.Text);
            lblTotalGastos.Text = total.ToString();
            try
            {
                ta.InsertGastos(total, Convert.ToInt32(lbId2.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Impuesto fr = new Impuesto();
            fr.Show();
            this.Hide();
        }

        private void FormGastos102A_Load(object sender, EventArgs e)
        {

        }
    }
}
