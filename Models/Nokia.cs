namespace DesafioPOO.Models
{
    public class Nokia : Smartphone // Herdar da classe "Smartphone"
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp) // Sobrescrever o método "InstalarAplicativo"
        {
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no seu NOKIA");
        }
    }
}