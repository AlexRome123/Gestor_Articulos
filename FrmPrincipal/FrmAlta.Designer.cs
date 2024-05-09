namespace FrmPrincipal
{
    partial class FrmAlta
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
            this.txbNombre2 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.lblCampoO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNombre2
            // 
            this.txbNombre2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre2.Location = new System.Drawing.Point(71, 60);
            this.txbNombre2.Multiline = true;
            this.txbNombre2.Name = "txbNombre2";
            this.txbNombre2.Size = new System.Drawing.Size(179, 27);
            this.txbNombre2.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre *";
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar2.Location = new System.Drawing.Point(46, 116);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(93, 34);
            this.btnAceptar2.TabIndex = 1;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar2.Location = new System.Drawing.Point(193, 116);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(94, 34);
            this.btnCancelar2.TabIndex = 2;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // lblCampoO
            // 
            this.lblCampoO.AutoSize = true;
            this.lblCampoO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoO.ForeColor = System.Drawing.Color.Red;
            this.lblCampoO.Location = new System.Drawing.Point(146, 25);
            this.lblCampoO.Name = "lblCampoO";
            this.lblCampoO.Size = new System.Drawing.Size(126, 16);
            this.lblCampoO.TabIndex = 4;
            this.lblCampoO.Text = "Campo Obligatorio";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 163);
            this.Controls.Add(this.lblCampoO);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnAceptar2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbNombre2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 202);
            this.MinimumSize = new System.Drawing.Size(345, 202);
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Label lblCampoO;
    }
}