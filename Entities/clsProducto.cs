using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsProducto
    {

        //Atributos
        private string nombre;
        //private decimal precio;
        //private int cantidad;
        //private string descripcion;

        //propiedades
        public void setNombre(string nombre) {
            //Validacion y comprobacion del dato
            if (nombre.Length >= 5) {
                throw new Exception("El nombre debe de tener mas de 5 caracteres");
            }
            this.nombre = nombre.ToLower();
        }

        public string getNombre() {
            return this.nombre;
        }

        //Forma nueva de crear atributos con sus propiedades
        public int id { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }

        //Constructores
        public clsProducto(int id, string nombre, int precio, int cantidad)
        {
            //Inicializar los atributos
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public clsProducto()
        {

        }

        //Metodos
        public decimal calcularPrecioTotal() {
            return this.precio * this.cantidad;
        }
    }
}