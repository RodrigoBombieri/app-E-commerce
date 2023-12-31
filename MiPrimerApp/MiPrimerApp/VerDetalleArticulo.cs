﻿using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using System.Net;
using System.Data.SqlClient;

namespace MiPrimerApp
{
    public partial class VerDetalleArticulo : Form
    {
      
        public VerDetalleArticulo(Articulo seleccionado)
        {
            
            InitializeComponent();

            lblCodigoArticulo.Text = seleccionado.Codigo;
            lblNombre.Text = seleccionado.Nombre;
            lblDescripcion.Text = seleccionado.Descripcion;
            lblMarca.Text = seleccionado.Marca.ToString();
            lblCategoria.Text = seleccionado.Categoria.ToString();
            lblPrecio.Text = seleccionado.Precio.ToString();
            cargarImagen(seleccionado.UrlImagen);
               
              
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pibVerDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                pibVerDetalle.Load("https://img.freepik.com/premium-vector/no-photo-available-vector-icon-default-image-symbol-picture-coming-soon-web-site-mobile-app_87543-10615.jpg?w=900");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
