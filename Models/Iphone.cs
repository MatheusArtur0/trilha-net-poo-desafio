namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
     public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {
            // Construtor da classe base (Smartphone) é chamado
        }

        // Sobrescreve o método "InstalarAplicativo" da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Iphone...");
        }
    }
}