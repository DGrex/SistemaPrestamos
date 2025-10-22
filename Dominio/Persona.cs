namespace Dominio { 
public abstract class Persona
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }

    protected Persona() { }

    protected Persona(string nombre, string cedula)
    {
        Nombre = nombre;
        Cedula = cedula;
    }

    public virtual string Identificarse() => $"{Nombre} ({Cedula})";
}
}

