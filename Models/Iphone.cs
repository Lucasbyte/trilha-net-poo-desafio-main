namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
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
           Console.WriteLine("ABRINDO LOJA DE APLICATIVO");
           Console.WriteLine($"instalando o aplicativo: {nomeApp}");
           for (int i = 0; i < 30; i++)
           {
            Console.Write(".");
            Thread.Sleep(667);
           }
           Console.WriteLine();
           Console.WriteLine("APP instalado");
        }
    }
}