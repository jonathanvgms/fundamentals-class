public class Visita
{
    private DateTime today;
    private Animal paciente;
    private Veterinario veterinario;
    private Especialista especialista;

    public Visita(DateTime today, Animal paciente, Veterinario veterinario)
    {
        this.today = today;
        this.paciente = paciente;
        this.veterinario = veterinario;
    }

    public Visita(DateTime today, Animal paciente, Especialista especialista)
    {
        this.today = today;
        this.paciente = paciente;
        this.especialista = especialista;
    }
}