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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            DataSet102ATableAdapters.Datos_Almacenados_UserTableAdapter ta = new DataSet102ATableAdapters.Datos_Almacenados_UserTableAdapter();
            DataSet102A.Datos_Almacenados_UserDataTable dt = ta.GetDatosVista();
            dataGridView1.DataSource = dt;
        }
    }
}
