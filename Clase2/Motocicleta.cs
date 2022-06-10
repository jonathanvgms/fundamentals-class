namespace Clase2
{
    public class Motocicleta
    {
        //atributos - caracteristicas

        public string patente { get; set; } //forma condesada de escribir metodos getter y setter

        public string color { get; set; }
        //public string color //forma explayada de escribir metodos getter y setter
        //{
        //    get { return color; }
        //    set {
        //        color = value;
        //        //if (value != "")
        //        //    color = value;
        //        //else
        //        //    Console.WriteLine("Color invalido");
        //    }
        //}

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private bool estadoMotor = false; // true = motor encendido y false = motor apagado

        //comportamiento
        public Motocicleta(string unaPatente, string unColor, string unModelo)
        {
            patente = unaPatente;
            this.color = unColor;
            this.modelo = unModelo;
            //this.estadoMotor = false; 
            // esta asignacion depende de que se utilice este constructor al momento
            //de la instanciacion del objeto
        }

        public Motocicleta(string unaPatente)
        {
            this.patente = unaPatente;
        }

        public void arrancar()
        {
            //if (estadoMotor == false)
            if (!estadoMotor)
                estadoMotor = true;
            else
                throw new Exception("El motor se encuentra encendido");
        }

        public void apagar()
        {
            if (estadoMotor)
                estadoMotor = false;
            else
                throw new Exception("El motor se encuentra apagado");
        }

        public bool verEstadoMotor() => estadoMotor;

        public string informar()
        {
            return $"Motocicleta de modelo: {modelo} con patente: {patente}  y de color {color}";
        }
    }
}
