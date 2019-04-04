using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AutenticarPlataformaResponse AutenticarPlataforma(AutenticarPlataformaRequest request);

        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
        
    }
}
