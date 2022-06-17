public class Veterinario
{
    private string nombre;
    private int edad;
    private DateTime fechaGraduacion;

    public Veterinario(string nombre, int edad, DateTime fechaGraduacion)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.fechaGraduacion = fechaGraduacion;
    }

    public int AniosRecibido() => DateTime.Now.Year - this.fechaGraduacion.Year;
    public string Nombre() => this.nombre;
    public int Edad() => this.edad;
    public string TipoMedico() => this.GetType().Name;
}