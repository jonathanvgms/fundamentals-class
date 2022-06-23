public interface IClinica
{
    void AgendarUna(Visita visita);
    void AgregarUn(Animal paciente);
    void AgregarUn(Persona cliente);
    void AgregarUn(Veterinario medico);
    void VerVisitasProgramadas();
}