public class Clinica : IClinica
{
    public List<Veterinario> medicos;
    public List<Persona> clientes;
    public List<Animal> pacientes;
    public List<Visita> visitas;
    public string nombre { get; set; }

    public Clinica(string nombre)
    {
        this.nombre = nombre;
        medicos = new List<Veterinario>();
        clientes = new List<Persona>();
        pacientes = new List<Animal>();
        visitas = new List<Visita>();
    }

    public void AgendarUna(Visita visita) => this.visitas.Add(visita);
    public void AgregarUn(Persona cliente) => this.clientes.Add(cliente);
    public void AgregarUn(IAnimal paciente) => this.pacientes.Add(paciente);
    public void AgregarUn(Veterinario medico) => this.medicos.Add(medico);

    public void VerVisitasProgramadas()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Clinica: {this.nombre}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Visitas Programadas");
        Console.WriteLine("------------------------------------");
        foreach (var visita in visitas)
        {
            Console.WriteLine($"Fecha: {visita.Fecha().ToShortDateString()}");
            Console.WriteLine($"Tipo: {visita.Veterinario().TipoMedico()}");
            Console.WriteLine($"Medico: {visita.Veterinario().Nombre()}");
            Console.WriteLine($"Paciente: {visita.Paciente().Nombre}");
            Console.WriteLine("------------------------------------");
        }
    }
}
