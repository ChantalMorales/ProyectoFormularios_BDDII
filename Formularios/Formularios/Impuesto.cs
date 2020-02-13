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
    public partial class Impuesto : Form
    {
        public static decimal total;
        private void ObtenerId()
        {
            lbId3.Text = Form102.id;
        }

        public Impuesto()
        {
            InitializeComponent();
            ObtenerId();
            DataSet102ATableAdapters.IngresosTableAdapter ta = new DataSet102ATableAdapters.IngresosTableAdapter();
            DataSet102A.IngresosDataTable dt = ta.GetValor_Ingresos(Convert.ToInt32(lbId3.Text));
            DataSet102A.IngresosRow row = (DataSet102A.IngresosRow)dt.Rows[0];
            DataSet102ATableAdapters.GastosTableAdapter tb = new DataSet102ATableAdapters.GastosTableAdapter();
            DataSet102A.GastosDataTable dt2 = tb.GetValor_Gastos(Convert.ToInt32(lbId3.Text));
            DataSet102A.GastosRow rowg = (DataSet102A.GastosRow)dt2.Rows[0];
            txtIT.Text = (row.valor_ingresos.ToString());
            txtGT.Text = (rowg.valor_gastos.ToString());
            
            
            total = decimal.Parse(txtIT.Text) - decimal.Parse(txtGT.Text);
            lbImpuesto.Text = total.ToString();

            

            
        }

        private void Impuesto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal fr = new Principal();
            fr.Show();
            this.Hide();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet102ATableAdapters.ContribuyenteTableAdapter cn = new DataSet102ATableAdapters.ContribuyenteTableAdapter();
            cn.UpdateSaldoTributario(total, Convert.ToInt32(lbId3.Text));
            Form106 fr = new Form106();
            fr.Show();
            this.Hide();
        }
    }
}
