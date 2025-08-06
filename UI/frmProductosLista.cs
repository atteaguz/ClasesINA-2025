using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmProductosLista : Form
    {
        public frmProductosLista()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.ShowDialog();
        }
        private void cargarLista()
        {
            //throw new NotImplementedException();
        }

        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}
