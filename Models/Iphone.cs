namespace DesafioPOO.Models
{
    public class Iphone : Smartphone // Herdar da classe "Smartphone"
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // DONE
        public override void InstalarAplicativo(string nomeApp) // Sobrescrever o método "InstalarAplicativo"
        {
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no seu IPHONE");
        }
    }
}
