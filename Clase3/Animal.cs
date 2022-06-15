public class Animal
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