namespace Entities
{
    public class clsClient
    {
        //Atributos de la clase Client
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Genero { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }

        //Constructor
        public clsClient(int Id, string Nombre, string Apellido1, string Apellido2,
        string Genero, DateOnly FechaNacimiento, string Correo, string Estado)
        {
            Id = Id;
            Nombre = Nombre;
            Apellido1 = Apellido1;
            Apellido2 = Apellido2;
            Genero = Genero;
            FechaNacimiento = FechaNacimiento;
            Correo = Correo;
            Estado = Estado;
        }
    }
}