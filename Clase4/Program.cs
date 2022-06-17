using Clase4;

var paciente = new Animal("Felino");
var cliente = new Persona("Jose", 23, "jose@mail.com");
paciente.FechaNacimiento = Convert.ToDateTime("2021-01-01");
paciente.Nombre = "Luna";
paciente.IntentosEscape = 2;
paciente.Castrado = true;
paciente.Duenio = cliente;
var veterinario = new Veterinario("Martin", 41, Convert.ToDateTime("1990-10-02"));
var primerVisita = new Visita(DateTime.Today, paciente, medico: veterinario);
var especialista = new Especialista("Marcelo", 34, Convert.ToDateTime("1995-11-03"));
especialista.AgregarUna(new Especie("Felino"));
especialista.AgregarUna(new Especie("Canino"));
var segundaVisita = new Visita(DateTime.Today, paciente, medico: especialista);

//forma de instanciacion de objetos de forma explicita e implicita

//var veterinario1 = new Veterinario("Veterinario1", 41, Convert.ToDateTime("1990-10-02"));
//Veterinario veterinario2 = new Veterinario("Veterinario2", 41, Convert.ToDateTime("1990-10-02"));
//var especialista1 = new Especialista("Especialista1", 41, Convert.ToDateTime("1990-10-02"));
//Especialista especialista2 = new Especialista("Especialista2", 41, Convert.ToDateTime("1990-10-02"));
//Veterinario especialista3 = new Especialista("Especialista3", 41, Convert.ToDateTime("1990-10-02"));

//forma de instanciar un objeto nueva version C#
Clinica clinica = new("PETS");

//forma de instanciar un objeto clasica explicito
//Clinica clinica = new Clinica("PETS");

//forma de instanciar un objeto clasica implicito
//var clinica = new Clinica("PETS");

//objeto maestro que controla al resto de objetos
clinica.AgregarUn(veterinario);
clinica.AgregarUn(especialista);
clinica.AgregarUn(cliente);
clinica.AgregarUn(paciente);
clinica.AgendarUna(primerVisita);
clinica.AgendarUna(segundaVisita);
clinica.VerVisitasProgramadas();