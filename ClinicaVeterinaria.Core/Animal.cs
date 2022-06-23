public class Animal : IAnimal
{
    public DateTime FechaNacimiento { get; set; }
    public string Nombre { get; set; }
    public int IntentosEscape { get; set; }
    public bool Castrado { get; set; }
    public Especie Especie { get; set; }
    public Persona Duenio { get; set; }

    public Animal(string especie)
    {
        this.Especie = new Especie(especie);
    }
}

public class Animal2 : IAnimal
{
    public DateTime FechaNacimiento { get; set; }
    public string Nombre { get; set; }
    public int IntentosEscape { get; set; }
    public bool Castrado { get; set; }
    public Especie Especie { get; set; }
    public Persona Duenio { get; set; }

    public Animal2(string especie)
    {
        this.Especie = new Especie(especie);
    }
}