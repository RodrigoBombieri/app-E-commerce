namespace MiPrimerApp
{
    partial class VerDetalleArticulo
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
            this.pibVerDetalle = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.grbDetalleArticulo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibVerDetalle)).BeginInit();
            this.grbDetalleArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pibVerDetalle
            // 
            this.pibVerDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibVerDetalle.Location = new System.Drawing.Point(258, 12);
            this.pibVerDetalle.Name = "pibVerDetalle";
            this.pibVerDetalle.Size = new System.Drawing.Size(287, 328);
            this.pibVerDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibVerDetalle.TabIndex = 0;
            this.pibVerDetalle.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(321, 609);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 50);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(47, 45);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(57, 16);
            this.lblCA.TabIndex = 9;
            this.lblCA.Text = "Cód. Art:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(47, 100);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 16);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nombre:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(47, 155);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 16);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(149, 151);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 20);
            this.lblDescripcion.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(149, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 20);
            this.lblNombre.TabIndex = 13;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(149, 41);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(0, 20);
            this.lblCodigoArticulo.TabIndex = 12;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(429, 155);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(90, 16);
            this.lblPre.TabIndex = 17;
            this.lblPre.Text = "Precio: ARS $";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(429, 100);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(69, 16);
            this.lblCat.TabIndex = 16;
            this.lblCat.Text = "Categoría:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(429, 45);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(48, 16);
            this.lblMa.TabIndex = 15;
            this.lblMa.Text = "Marca:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(540, 151);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblPrecio.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(540, 100);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 20);
            this.lblCategoria.TabIndex = 19;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(540, 45);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 20);
            this.lblMarca.TabIndex = 18;
            // 
            // grbDetalleArticulo
            // 
            this.grbDetalleArticulo.Controls.Add(this.lblPrecio);
            this.grbDetalleArticulo.Controls.Add(this.lblCategoria);
            this.grbDetalleArticulo.Controls.Add(this.lblMarca);
            this.grbDetalleArticulo.Controls.Add(this.lblPre);
            this.grbDetalleArticulo.Controls.Add(this.lblCat);
            this.grbDetalleArticulo.Controls.Add(this.lblMa);
            this.grbDetalleArticulo.Controls.Add(this.lblDescripcion);
            this.grbDetalleArticulo.Controls.Add(this.lblNombre);
            this.grbDetalleArticulo.Controls.Add(this.lblCodigoArticulo);
            this.grbDetalleArticulo.Controls.Add(this.lblDesc);
            this.grbDetalleArticulo.Controls.Add(this.lblNom);
            this.grbDetalleArticulo.Controls.Add(this.lblCA);
            this.grbDetalleArticulo.Location = new System.Drawing.Point(26, 367);
            this.grbDetalleArticulo.Name = "grbDetalleArticulo";
            this.grbDetalleArticulo.Size = new System.Drawing.Size(747, 205);
            this.grbDetalleArticulo.TabIndex = 21;
            this.grbDetalleArticulo.TabStop = false;
            this.grbDetalleArticulo.Text = "Detalle Articulo:";
            // 
            // VerDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.grbDetalleArticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pibVerDetalle);
            this.Name = "VerDetalleArticulo";
            this.Text = "VerDetalleArticulo";
            this.Load += new System.EventHandler(this.VerDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibVerDetalle)).EndInit();
            this.grbDetalleArticulo.ResumeLayout(false);
            this.grbDetalleArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibVerDetalle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox grbDetalleArticulo;
    }
}