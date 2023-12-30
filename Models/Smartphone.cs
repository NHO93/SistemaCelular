namespace DesafioPOO.Models
{
    public abstract class Smartphone // Transformar a classe em abstrata
    {
        public string Numero { get; set; } // Transformar as propriedades em públicas
        private string Modelo { get; set; } // Transformar as propriedades em privadas
        private string IMEI { get; set; } // Transformar as propriedades em privadas
        private int Memoria { get; set; } // Transformar as propriedades em privadas

        public Smartphone(string numero, string modelo, string imei, int memoria) // Criar um construtor para a classe
        {
            this.Numero = numero; // Atribuir os valores recebidos às propriedades
            this.Modelo = modelo; // Atribuir os valores recebidos às propriedades
            this.IMEI = imei; // Atribuir os valores recebidos às propriedades
            this.Memoria = memoria; // Atribuir os valores recebidos às propriedades
        }

        public void Ligar() // Criar um método para a classe
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() // Criar um método para a classe
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp); // Criar um método abstrato para a classe
    }
}