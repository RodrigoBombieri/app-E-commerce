using negocio;
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
        private List<Articulo> listaArticulos;

        
       
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

        

        private void VerDetalleArticulo_Load(object sender, EventArgs e)
        {
            
            Cargar();
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

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                listaArticulos = negocio.listar();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

            
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
