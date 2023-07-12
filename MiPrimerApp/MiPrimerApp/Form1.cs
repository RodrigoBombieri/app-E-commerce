using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace MiPrimerApp
{
    public partial class FormCatalogo : Form
    {
        // Creo una lista para manipular la lista de articulos
        private List<Articulo> listaArticulos;
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            Cargar();
            
            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }
        }



        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                // se recibe el datasource y se modela el formulario, e invocamos el método listar que devuelve el listado que configuramos
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                // llama a la función para cargar la imágen en la primera posición
                CargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pibArticulos.Load(imagen);
            }
            catch (Exception ex)
            {

                pibArticulos.Load("https://img.freepik.com/premium-vector/no-photo-available-vector-icon-default-image-symbol-picture-coming-soon-web-site-mobile-app_87543-10615.jpg?w=900");
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAltaArticulo alta = new FormAltaArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            FormAltaArticulo modificar = new FormAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    if(logico)
                    {
                        negocio.eliminar(seleccionado.Id);
                    }
                    else
                    {
                        negocio.eliminar(seleccionado.Id);
                    }
                    //Cuando eliminamos se actualiza la grilla
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
