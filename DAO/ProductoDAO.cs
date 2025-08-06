using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    public class ProductoDAO
    {
        /*public void guardar()
        {

        }*/

        //Creacion de lista de productos
        public List<clsProducto> ListaProducto { get; set; }

        //Constructor
        public ProductoDAO()
        {
            //Inicializar la lista de productos
            ListaProducto = new List<clsProducto>();
        }

        //Creacion de nuevos productos
        public void crear(clsProducto producto) 
        {
            //Agregar un nuevo producto a la lista
            ListaProducto.Add(producto);
        }

        //Modificar un producto existente
        public void modificar(clsProducto producto)
        {
            //Solo se puede modificar un producto si ya existe en la lista
            //expresion lambda
            clsProducto prodModificar = ListaProducto.Where(p => p.id == producto.id).SingleOrDefault();

            //indice de la lista
            int indice = ListaProducto.IndexOf(prodModificar);
            ListaProducto[indice] = producto;
        }

        //Eliminar un producto existente de la lista
        public void eliminar(int id)
        {
            //Buscar el producto por id
            clsProducto producto = ListaProducto.Where(p => p.id == id).SingleOrDefault();
            //Eliminar el producto de la lista
            ListaProducto.Remove(producto);
        }

        //Consultar un producto existente por id
        public clsProducto consultarPorId(int id)
        {
            //Buscar el producto por id y retornar el producto encontrado
            return ListaProducto.Where(p => p.id == id).SingleOrDefault();
        }

        //Consultar un producto existente por nombre
        public clsProducto consultarPorNombre(string nombre)
        {
            //Buscar el producto por nombre y retornar el producto encontrado
            return ListaProducto.Where(p => p.getNombre().Trim().ToLower() == nombre).SingleOrDefault();
        }

        //Consultar todos los productos de la lista
        public List<clsProducto> consultarTodo(clsProducto producto)
        {
            //Retorna toda la lista
            return ListaProducto;
        }
    }
}