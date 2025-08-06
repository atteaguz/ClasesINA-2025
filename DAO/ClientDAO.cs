using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    public class ClientDAO
    {
        //CRUD de clientes

        //Creacion de lista para guardar los clientes
        public List<clsClient> ListaClientes { get; set; }

        //Constructor
        public ClientDAO()
        {
            //Inicializar la lista de productos
            ListaClientes = new List<clsClient>();
        }

        //Crear clientes nuevos
        public void CrearCliente(clsClient cliente)
        {
            //Codigo para crear un cliente
            ListaClientes.Add(cliente);
        }

        //Modificar clientes existentes por su Id
        public void ModificarCliente(clsClient cliente)
        {
            //Codigo para modificar un cliente con lambda
            clsClient modCliente = ListaClientes.SingleOrDefault(c => c.Id == cliente.Id);

            int indice = ListaClientes.IndexOf(modCliente);
            ListaClientes[indice] = cliente;
        }

        //Eliminar clientes existentes por su Id
        public void eliminarCliente(int Id)
        {
            //Buscar al cliente por su id
            clsClient cliente = ListaClientes.Where(c => c.Id == Id).SingleOrDefault();
            //Eliminar el producto de la lista
            ListaClientes.Remove(cliente);
        }

        //Buscar clientes por su Id
        public clsClient BuscarCliente(int Id)
        {
            //Buscar al cliente por su id
            clsClient cliente = ListaClientes.Where(c => c.Id == Id).SingleOrDefault();
            return cliente;
        }

        //Ver todos los clientes
        public List<clsClient> VerClientes()
        {
            //Retornar la lista de clientes
            return ListaClientes;
        }
    }
}