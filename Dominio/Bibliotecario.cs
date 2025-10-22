namespace Dominio
{
    // Clase que representa a un bibliotecario dentro del sistema.
    // Hereda de la clase Persona, lo que implica que comparte atributos comunes como nombre y cédula.
    public class Bibliotecario : Persona
    {
        // Constructor por defecto. Permite instanciar un bibliotecario sin asignar valores iniciales.
        public Bibliotecario() { }

        // Constructor parametrizado. Permite crear un bibliotecario con nombre y cédula definidos.
        // Utiliza el constructor de la clase base Persona para inicializar dichos atributos.
        public Bibliotecario(string nombre, string cedula)
            : base(nombre, cedula) { }
    }
}