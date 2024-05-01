﻿using System;
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
    public partial class FrmGestor : Form
    {
        public FrmGestor()
        {
            InitializeComponent();
            cargarImagen("");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                articulo.Categoria = (Categorias)cbxCategoria.SelectedItem;
                articulo.Marca = (Marcas)cbxMarca.SelectedItem;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.ImagenUrl = txbUrlImagen.Text;
                articulo.Codigo = txbCodigo.Text;
                negocio.Agregar(articulo);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

    }
}
