namespace FrmPrincipal
{
    partial class FrmGestor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.ptbAriculoG = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAriculoG)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(93, 147);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(188, 20);
            this.txbNombre.TabIndex = 0;
            this.txbNombre.Text = "Nombre";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(93, 191);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txbDescripcion.TabIndex = 1;
            this.txbDescripcion.Text = "Descripción";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(93, 238);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(188, 20);
            this.txbPrecio.TabIndex = 2;
            this.txbPrecio.Text = "Precio";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(93, 58);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(188, 21);
            this.cbxCategoria.TabIndex = 3;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(93, 102);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(188, 21);
            this.cbxMarca.TabIndex = 4;
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(93, 282);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(188, 20);
            this.txbUrlImagen.TabIndex = 5;
            this.txbUrlImagen.Text = "Imagen";
            this.txbUrlImagen.Leave += new System.EventHandler(this.txbUrlImagen_Leave);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(93, 327);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(188, 20);
            this.txbCodigo.TabIndex = 6;
            this.txbCodigo.Text = "Código";
            // 
            // ptbAriculoG
            // 
            this.ptbAriculoG.Location = new System.Drawing.Point(355, 54);
            this.ptbAriculoG.Name = "ptbAriculoG";
            this.ptbAriculoG.Size = new System.Drawing.Size(300, 300);
            this.ptbAriculoG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAriculoG.TabIndex = 7;
            this.ptbAriculoG.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(226, 395);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(381, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ptbAriculoG);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 489);
            this.MinimumSize = new System.Drawing.Size(768, 489);
            this.Name = "FrmGestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.FrmGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAriculoG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.PictureBox ptbAriculoG;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}