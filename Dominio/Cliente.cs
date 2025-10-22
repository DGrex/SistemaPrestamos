namespace Dominio
{
    // Clase que representa a un cliente dentro del sistema de préstamos.
    // Hereda de la clase Persona, lo que implica que posee atributos comunes como nombre y cédula.
    public class Cliente : Persona
    {
        // Propiedad que almacena el número de teléfono del cliente.
        public string Telefono { get; set; }

        // Constructor por defecto. Permite instanciar un cliente sin asignar valores iniciales.
        public Cliente() { }

        // Constructor parametrizado. Permite crear un cliente con nombre, cédula y teléfono definidos.
        // Utiliza el constructor de la clase base Persona para inicializar nombre y cédula.
        public Cliente(string nombre, string cedula, string telefono)
            : base(nombre, cedula)
        {
            Telefono = telefono;
        }

        // Método sobrescrito que retorna una cadena identificativa del cliente.
        // Incluye la identificación base (nombre y cédula) y el número de teléfono.
        public override string Identificarse() => $"{base.Identificarse()} - Tel: {Telefono}";

        // Método sobrescrito que retorna una representación textual del cliente.
        // Incluye nombre, cédula y teléfono en formato concatenado.
        public override string ToString()
        {
            return $"{Nombre} - {Cedula} - {Telefono}";
        }
    }
}

