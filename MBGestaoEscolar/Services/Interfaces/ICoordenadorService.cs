using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Services.Interfaces
{
    public interface ICoordenadorService
    {
        Task<IEnumerable<Coordenador>> ListaCoordenadorsAsync();
        Task<Coordenador> ObterCoordenadorAsync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AtualizarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
