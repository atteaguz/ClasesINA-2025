using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductoService
    {
        //Reglas de negocio

        //Instancia a la capa DAO
        ProductoDAO _prodDAO = new ProductoDAO();

        //Constructor
        public ProductoService(){
        
        }

        public void crear(clsProducto producto)
        {
            //Reglas de negocio para crear un producto
            //El precio debe ser mayor a cero
            if (producto.precio <= 0)
            {
                throw new Exception("El precio no puede ser cero o menor a cero");
            }

            //Los IDs no pueden repetirse
            if (_prodDAO.consultarPorId(producto.id) != null)
            {
                throw new Exception("El ID del producto ya existe");
            }

            //El nombre no debe ser nulo o vacio
            if (string.IsNullOrEmpty(producto.getNombre()))
            {
                throw new Exception("El nombre del producto no puede ser nulo o vacio");
            }

            //Los nombres no pueden repetirse
            if (_prodDAO.consultarPorNombre(producto.getNombre().Trim().ToLower()) != null)
            {
                throw new Exception("El nombre del producto ya existe");
            }

            //Cuando se cumplan todas las validaciones, se crea el producto
            _prodDAO.crear(producto);
        }

        public void modificar(clsProducto producto)
        {
            //Reglas de negocio para modificar un producto
            //El precio debe ser mayor a cero
            if (producto.precio <= 0)
            {
                throw new Exception("El precio no puede ser cero o menor a cero");
            }

            //Los IDs no pueden repetirse
            if (_prodDAO.consultarPorId(producto.id) == null)
            {
                throw new Exception("El producto no existe");
            }

            //El nombre no debe ser nulo o vacio
            if (string.IsNullOrEmpty(producto.getNombre()))
            {
                throw new Exception("El nombre del producto no puede ser nulo o vacio");
            }

            //Los nombres no pueden repetirse
            if (_prodDAO.consultarPorNombre(producto.getNombre().Trim().ToLower()) != null)
            {
                throw new Exception("El nombre del producto ya existe");
            }

            //Cuando se cumplan todas las validaciones, se modifica el producto
            _prodDAO.modificar(producto);

        }


        public void eliminar(int id)
        {
            //Reglas de negocio para eliminar un producto existente
            //Si el producto no existe, no se puede eliminar
            if (_prodDAO.consultarPorId(id) == null)
            {
                throw new Exception("El producto no existe");
            }

            //Cuando se cumplan todas las validaciones, se elimina el producto
            _prodDAO.eliminar(id);
        }


        public clsProducto consultarPorId(int id)
        {
            //Reglas de negocio para consultar un producto por ID
            return _prodDAO.consultarPorId(id);
        }


        public List<clsProducto> consultarTodo(clsProducto producto)
        {
            //Reglas de negocio para consultar todos los productos
            return _prodDAO.ListaProducto;
        }
    }
}