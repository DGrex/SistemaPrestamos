namespace Dominio
{
    // Clase abstracta que representa una persona dentro del sistema.
    // Sirve como clase base para entidades como Cliente y Bibliotecario.
    public abstract class Persona
    {
        // Propiedad que almacena el nombre de la persona.
        public string Nombre { get; set; }

        // Propiedad que almacena la cédula de identidad de la persona.
        public string Cedula { get; set; }

        // Constructor protegido por defecto. Permite la creación de instancias derivadas sin inicializar propiedades.
        protected Persona() { }

        // Constructor protegido parametrizado. Permite inicializar nombre y cédula desde clases derivadas.
        protected Persona(string nombre, string cedula)
        {
            Nombre = nombre;
            Cedula = cedula;
        }

        // Método virtual que retorna una cadena identificativa de la persona.
        // Puede ser sobrescrito por clases derivadas para incluir información adicional.
        public virtual string Identificarse() => $"{Nombre} ({Cedula})";
    }
}

