using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ....");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do serviço ....");


            //AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instancia do meu objeto request ....");
            //request.Email = "Bruno@bruno.com";
            //request.Senha = "123456";

            var request = new AdicionarJogadorRequest()
            {
                Email = "bruno@hotmail.com",
                PrimeiroNome = "Bruno  Pereira",
                UltimoNome = "Machado",
                Senha = "123456"
            };

            var response = service.AdicionarJogador(request);


            Console.WriteLine("Serviço é valido ->" + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });


            Console.ReadKey();
        }
    }
}
