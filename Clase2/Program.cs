using Clase2;

//instanciar un objeto motocicleta (en una linea)
//Motocicleta motocicleta1 = new Motocicleta("ASD 123", "negro", "1999");

//instanciar un objeto motocicleta (en dos lineas)
//Motocicleta motocicleta2;

//motocicleta2 = new Motocicleta("QWE 345", "azul", "2022");

//instancia un objeto motocicleta (unicamente con la patente)
Motocicleta motocicleta3 = new Motocicleta("ZXC 123");
motocicleta3.Modelo = "2004";

Console.WriteLine(motocicleta3.Modelo);
motocicleta3.color = "Verde";
Console.WriteLine(motocicleta3.color);
Console.WriteLine(motocicleta3.patente);

Console.WriteLine($"Estado: {motocicleta3.verEstadoMotor()}");

motocicleta3.arrancar();
motocicleta3.arrancar(); //tira excepcion

Console.WriteLine($"Estado: {motocicleta3.verEstadoMotor()}");
motocicleta3.apagar();
Console.WriteLine($"Estado: {motocicleta3.verEstadoMotor()}");
Console.WriteLine(motocicleta3.informar());

Console.ReadKey();