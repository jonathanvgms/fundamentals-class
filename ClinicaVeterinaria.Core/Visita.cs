public class Visita
{
    private DateTime fecha;
    private IAnimal paciente;
    private Veterinario medico;

    public Visita(DateTime fecha, IAnimal paciente, Veterinario medico)
    {
        this.fecha = fecha;
        this.paciente = paciente;
        this.medico = medico;
    }

    public DateTime Fecha() => this.fecha;
    public Animal Paciente() => this.paciente;
    public Veterinario Veterinario() => this.medico;
}