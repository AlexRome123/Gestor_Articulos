using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        private List<Articulos> listaArticulos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                ArticulosNegocio datos = new ArticulosNegocio();
                listaArticulos = datos.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns[0].Visible= false;
                dgvArticulos.Columns[6].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
