using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace Daiko_DESKTOP.Controles
{
    public partial class DataGridViewPaginado : UserControl
    {
        private DataTable datos = new DataTable();
        public int totalRegistros = 0;
        public int pagina = 0;
        public int maximoPaginas = 0;
        public int registrosPorPagina = 1;

        public DataGridViewPaginado()
        {
            InitializeComponent();
        }

        public void CargarDatos(DataTable dt)
        {
            datos = dt;

            totalRegistros = dt.Rows.Count;

            if (totalRegistros != 0)
                maximoPaginas = totalRegistros % registrosPorPagina == 0 ? (totalRegistros / registrosPorPagina) : (totalRegistros / registrosPorPagina) + 1;

            labelTotalPaginas.Text = maximoPaginas.ToString();

            dataGridView1.DataSource = datos;
        }

        //private DataTable Split(DataTable datos)
        //{
        //    return datos.Select().Take(registrosPorPagina).CopyToDataTable();
        //}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pagina++;
        }
    }
}
