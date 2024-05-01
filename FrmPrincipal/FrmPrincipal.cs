using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
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
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargar()
        {
            try
            {
                ArticulosNegocio datos = new ArticulosNegocio();
                listaArticulos = datos.listar();
                dgvArticulos.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].ImagenUrl);
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[6].Visible = false;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                ptbArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbArticulos.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
                txbNombreM.Text = seleccionado.Nombre;
                txbPrecioM.Text = seleccionado.Precio.ToString("C2");
                txbDescripcionM.Text = seleccionado.Descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestor gestor = new FrmGestor();
            gestor.ShowDialog();
            cargar();
        }
    }
}
