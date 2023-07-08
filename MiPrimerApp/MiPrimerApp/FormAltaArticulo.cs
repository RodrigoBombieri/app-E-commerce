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
using negocio;
using System.Configuration;

namespace MiPrimerApp
{
    public partial class FormAltaArticulo : Form
    {
        private Articulo articulo = null;

        private OpenFileDialog archivo = null;
        
        public FormAltaArticulo()
        {
            InitializeComponent();
        }

        public FormAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
    }
}
