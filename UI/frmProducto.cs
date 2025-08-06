using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Utils;

namespace UI
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos()){
                    clsProducto producto = new clsProducto();
                    producto.id = Convert.ToInt32(txtId.Text);
                    producto.setNombre(txtNombre.Text);
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool validarDatos()
        {
            //Validaciones de los datos de entrada
            if (txtId.Text.Length <= 0){
                MessageBox.Show("El ID del producto es obligatorio y debe ser diferente de cero (0).");
                txtId.Focus();
                return false;
            }
            if (txtNombre.Text.Length == 0 || txtNombre.Text.Length < 5){
                MessageBox.Show("El nombre del producto es obligatorio y debe tener mas de 5 caracteres.");
                txtNombre.Focus();
                return false;
            }
            if (txtPrecio.Text.Length == 0 || !Validator.IsDecimal(txtPrecio.Text) || decimal.Parse(txtNombre.Text) <= 0 ){
                MessageBox.Show("El precio del producto es obligatorio y debe ser mayor a cero (0).");
                txtPrecio.Focus();
                return false;
            }
            if (txtCantidad.Value < 0){ 
                MessageBox.Show("La cantidad del producto es obligatoria.");
                txtCantidad.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
