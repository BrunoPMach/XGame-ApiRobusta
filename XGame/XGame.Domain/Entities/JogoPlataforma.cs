using System;

namespace XGame.Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; set; }

        public Jogo jogo { get; set; }

        public Plataforma plataforma { get; set; }

        public DateTime DataLancamento { get; set; }




    }
}
