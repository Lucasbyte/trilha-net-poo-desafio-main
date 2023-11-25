
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"


    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void ExibirDados()
        {
            Console.WriteLine(@$"
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Exibindo INFORMAÇÕES

            Seu numero é: {Numero}
            Imei: {Imei}
            Modelo: {Modelo}
            Memoria: {Memoria}
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
" 
            );
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("A loja de aplicativos se encontra indisponivel");
            Console.WriteLine($"Por isso não foi possivel instalar: {nomeApp}");
        }
    }
}