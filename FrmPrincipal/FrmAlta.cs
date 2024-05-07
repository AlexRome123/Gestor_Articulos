using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmAlta : Form
    {
        private bool marca2 = false;
        public FrmAlta(bool marca)
        {
            InitializeComponent();
            if(marca == true)
            {
                Text = "Alta Marca";
                marca2 = true;
            }
            lblCampoO.Visible = false;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            if(txbNombre2.Text != "")
            {
                if (marca2 == false)
                {
                    CategoriasNegocio datos = new CategoriasNegocio();
                    Categorias nueva = new Categorias();
                    nueva.Descripcion = txbNombre2.Text;
                    try
                    {
                        datos.agregar(nueva);
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MarcasNegocio datos = new MarcasNegocio();
                    Marcas nueva = new Marcas();
                    nueva.Descripcion= txbNombre2.Text;
                    try
                    {
                        datos.agregar(nueva); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                this.Close();
            }
            else
            {
                lblCampoO.Visible = true;
            }

        }
    }
}
