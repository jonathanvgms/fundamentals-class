public class Especialista
{
    public Veterinario Veterinario { get; set; }

    public List<Especie> Especialidades { get; set; }

    public Especialista(Veterinario unVeterinario)
    {
        this.Veterinario = unVeterinario;
        this.Especialidades = new List<Especie>();
    }

    public void AgregarUna(Especie especialidad) => this.Especialidades.Add(especialidad);
}
