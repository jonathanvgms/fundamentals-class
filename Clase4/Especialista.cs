public class Especialista : Veterinario
{
    public List<Especie> Especialidades { get; set; }
    public Especialista(string nombre, int edad, DateTime fechaGraduacion)
        : base(nombre, edad, fechaGraduacion)
    {
        this.Especialidades = new List<Especie>();
    }

    public void AgregarUna(Especie especialidad) => this.Especialidades.Add(especialidad);
}
