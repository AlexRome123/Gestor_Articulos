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
                cargarFiltro();
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
                prepararDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void prepararDgv()
        {
            dgvArticulos.Columns[0].Visible = false;
            dgvArticulos.Columns[6].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
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
            cargarFiltro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                FrmGestor gestor = new FrmGestor(seleccionado);
                gestor.ShowDialog();
                cargar();
                cargarFiltro();
            }
            else
                MessageBox.Show("Seleccione un Artículo");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(dgvArticulos.CurrentRow != null)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro deseas eliminar?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if(resultado == DialogResult.Yes)
                    {
                        ArticulosNegocio datos = new ArticulosNegocio();
                        Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                        datos.eliminar(seleccionado);
                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Seleccione un Artículo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio datos = new ArticulosNegocio();
            Categorias cate = (Categorias)cmbCategoria.SelectedItem;
            Marcas marc = (Marcas)cmbMarca.SelectedItem;
            string busq = txbfiltro.Text;
            try
            {
                listaArticulos = datos.buscar(cate, marc, busq);
                dgvArticulos.DataSource = listaArticulos;
                prepararDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cmbCategoria.SelectedIndex = -1;
                cmbMarca.SelectedIndex = -1;
                txbfiltro.Clear();
            }

        }
        private void cargarFiltro()
        {
            CategoriasNegocio catNegocio = new CategoriasNegocio();
            MarcasNegocio marcNegocio = new MarcasNegocio();
            try
            {
                cmbCategoria.DataSource = catNegocio.Listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";
                cmbMarca.DataSource = marcNegocio.Listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";
                cmbCategoria.SelectedIndex = -1;
                cmbMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
