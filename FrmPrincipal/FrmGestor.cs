using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public partial class FrmGestor : Form
    {
        private Articulos articulo = null;
        public FrmGestor()
        {
            InitializeComponent();
            cargarImagen("");
        }
        public FrmGestor(Articulos modificado)
        {
            InitializeComponent();
            Text = "Modificar Artículo";
            articulo = modificado;
        }
        private void FrmGestor_Load(object sender, EventArgs e)
        {
            CategoriasNegocio desplegableCategoria = new CategoriasNegocio();
            MarcasNegocio desplegableMarca = new  MarcasNegocio();
            try
            {
                cbxCategoria.DataSource = desplegableCategoria.Listar();
                cbxMarca.DataSource = desplegableMarca.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString("0.00");
                    txbUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txbCodigo.Text = articulo.Codigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            if(txbNombre.Text != "" && txbPrecio.Text != "")
            {
                try
                {
                    if (articulo == null)
                        articulo = new Articulos();
                    articulo.Categoria = (Categorias)cbxCategoria.SelectedItem;
                    articulo.Marca = (Marcas)cbxMarca.SelectedItem;
                    articulo.Nombre = txbNombre.Text;
                    articulo.Descripcion = txbDescripcion.Text;
                    articulo.Precio = decimal.Parse(txbPrecio.Text);
                    articulo.ImagenUrl = txbUrlImagen.Text;
                    articulo.Codigo = txbCodigo.Text;

                    if(articulo.Id !=0)
                        negocio.modificar(articulo);
                    else
                        negocio.Agregar(articulo);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                if (txbNombre.Text == "")
                    txbNombre.BackColor = Color.Red;
                else
                    txbNombre.BackColor = Color.White;
                if (txbPrecio.Text == "")
                    txbPrecio.BackColor = Color.Red;
                else
                    txbPrecio.BackColor = Color.White;
            }
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                ptbAriculoG.Load(imagen);
            }
            catch (Exception ex)
            {

                ptbAriculoG.Load("https://media.istockphoto.com/id/1147544807/es/vector/no-imagen-en-miniatura-gr%C3%A1fico-vectorial.jpg?s=612x612&w=0&k=20&c=Bb7KlSXJXh3oSDlyFjIaCiB9llfXsgS7mHFZs6qUgVk=");
            }
        }
        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
