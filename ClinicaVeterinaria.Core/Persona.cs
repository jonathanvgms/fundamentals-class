public class Persona 
{
    private string nombre;
    private int edad;
    private string email;

    public Persona(string nombre, int edad, string email)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.email = email;
    }

    public string Nombre() => this.nombre;

    public string Email() => this.email;

    public int Edad() => this.edad;
}