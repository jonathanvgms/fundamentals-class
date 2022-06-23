IAnimal paciente = new Animal2("Felino");
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

Clinica clinica = new("PETS");

clinica.AgregarUn(veterinario);
clinica.AgregarUn(especialista);
clinica.AgregarUn(cliente);
clinica.AgregarUn(paciente);
clinica.AgendarUna(primerVisita);
clinica.AgendarUna(segundaVisita);
clinica.VerVisitasProgramadas();

