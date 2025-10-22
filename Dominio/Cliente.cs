namespace Dominio
{
public class Cliente : Persona
{
    public string Telefono { get; set; }

    public Cliente() { }

    public Cliente(string nombre, string cedula, string telefono)
        : base(nombre, cedula)
    {
        Telefono = telefono;
    }

    public override string Identificarse() => $"{base.Identificarse()} - Tel: {Telefono}";

        public override string ToString()
        {
            return $"{Nombre} - {Cedula} - {Telefono}";
        }

    }


}

