using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAO;

namespace Services
{
    public class ClientServices
    {
        //Reglas de negocio para la insercion y actualizacion de clientes

        //Objeto para poder usar la capa DAO
        ClientDAO cliente = new ClientDAO();

        //Constructor
        public ClientServices()
        {

        }

        //Regla de negocio para crear un cliente nuevo
        public void crearCliente(clsClient cliente)
        {

            //Validar que el Id de cliente no sea nulo o vacio
            if (cliente.Id <= 0)
            {
                throw new Exception("El Id del cliente no puede ser nulo o vacio");
            }

            //Validar que el Id de cliente no exista
            if (this.cliente.BuscarCliente(cliente.Id) != null)
            {
                throw new Exception("El cliente ya existe");
            }

            //Validar que nombre, apellido1 y apellido2 no sean nulos o vacios
            if (string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Apellido1) ||
                string.IsNullOrWhiteSpace(cliente.Apellido2))
            {
                throw new Exception("El nombre, apellido1 y apellido2 no pueden ser nulos o vacios");
            }

            //Validar que genero sea "Masculino" o "Femenino" y no nulo o vacio
            if (string.IsNullOrWhiteSpace(cliente.Genero) ||
                (cliente.Genero != "Masculino" && cliente.Genero != "Femenino"))
            {
                throw new Exception("El genero debe ser 'Masculino' o 'Femenino' y no puede ser nulo o vacio");
            }

            //Validar que la fecha de nacimiento no sea nula o vacia ni que sea futura
            if (cliente.FechaNacimiento == default(DateOnly) ||
                cliente.FechaNacimiento > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new Exception("La fecha de nacimiento no puede ser nula, vacia o futura");
            }

            //validar que el correo tenga un formato valido
            if (!cliente.Correo.Contains("@") || !cliente.Correo.Contains("."))
            {
                throw new Exception("El correo no tiene un formato valido");
            }

            //Validar que el correo no exista
            if (this.cliente.ListaClientes.Any(c => c.Correo == cliente.Correo))
            {
                throw new Exception("El correo ya existe");
            }

            //Validar que el estado sea "Soltero/a" o "Casado/a" y que no sea nulo o vacio
            if (string.IsNullOrWhiteSpace(cliente.Estado) ||
                (cliente.Estado != "Soltero/a" && cliente.Estado != "Casado/a"))
            {
                throw new Exception("El estado debe ser 'Soltero/a' o 'Casado/a' y no puede ser nulo o vacio");
            }

            //Si todas las validaciones pasan, se crea un cliente nuevo
            this.cliente.CrearCliente(cliente);
        }

        //Regla de negocio para modificar un cliente existente por su Id
        public void modificarCliente(clsClient cliente)
        {
            //Validar que el Id de cliente no sea nulo o vacio
            if (cliente.Id <= 0)
            {
                throw new Exception("El Id del cliente no puede ser nulo o vacio");
            }

            //Validar que el Id de cliente exista
            if (this.cliente.BuscarCliente(cliente.Id) == null)
            {
                throw new Exception("El cliente no existe");
            }

            //Validar que nombre, apellido1 y apellido2 no sean nulos o vacios
            if (string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Apellido1) ||
                string.IsNullOrWhiteSpace(cliente.Apellido2))
            {
                throw new Exception("El nombre, apellido1 y apellido2 no pueden ser nulos o vacios");
            }

            //Validar que genero sea "Masculino" o "Femenino" y no nulo o vacio
            if (string.IsNullOrWhiteSpace(cliente.Genero) ||
                (cliente.Genero != "Masculino" && cliente.Genero != "Femenino"))
            {
                throw new Exception("El genero debe ser 'Masculino' o 'Femenino' y no puede ser nulo o vacio");
            }

            //Validar que la fecha de nacimiento no sea nula o vacia ni que sea futura
            if (cliente.FechaNacimiento == default(DateOnly) ||
                cliente.FechaNacimiento > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new Exception("La fecha de nacimiento no puede ser nula, vacia o futura");
            }

            //validar que el correo tenga un formato valido
            if (!cliente.Correo.Contains("@") || !cliente.Correo.Contains("."))
            {
                throw new Exception("El correo no tiene un formato valido");
            }

            //Validar que el correo no exista en otro cliente
            if (this.cliente.ListaClientes.Any(c => c.Correo == cliente.Correo && c.Id != cliente.Id))
            {
                throw new Exception("El correo ya existe en otro cliente");
            }

            //Validar que el estado sea "Soltero/a" o "Casado/a" y que no sea nulo o vacio
            if (string.IsNullOrWhiteSpace(cliente.Estado) ||
                (cliente.Estado != "Soltero/a" && cliente.Estado != "Casado/a"))
            {
                throw new Exception("El estado debe ser 'Soltero/a' o 'Casado/a' y no puede ser nulo o vacio");
            }

            //Si todas las validaciones pasan, se modifica el cliente
            this.cliente.ModificarCliente(cliente);
        }

        //Regla de negocio para eliminar un cliente existente por su Id
        public void eliminarCliente(int Id)
        {
            //Validar que el Id de cliente no sea nulo o vacio
            if (Id <= 0)
            {
                throw new Exception("El Id del cliente no puede ser nulo o vacio");
            }
            //Validar que el Id de cliente exista
            if (this.cliente.BuscarCliente(Id) == null)
            {
                throw new Exception("El cliente no existe");
            }
            //Si todas las validaciones pasan, se elimina el cliente
            this.cliente.eliminarCliente(Id);
        }

        //Regla de negocio para buscar un cliente por su Id
        public clsClient buscarCliente(int Id)
        {
            //Validar que el Id de cliente no sea nulo o vacio
            if (Id <= 0)
            {
                throw new Exception("El Id del cliente no puede ser nulo o vacio");
            }
            //Buscar el cliente por su Id
            clsClient cliente = this.cliente.BuscarCliente(Id);

            //Validar que el cliente exista
            if (cliente == null)
            {
                throw new Exception("El cliente no existe");
            }
            return cliente;
        }

        //Regla de negocio para ver a todos los clientes
        public List<clsClient> verClientes()
        {
            //Retornar la lista de clientes
            return this.cliente.VerClientes();
        }
    }
}