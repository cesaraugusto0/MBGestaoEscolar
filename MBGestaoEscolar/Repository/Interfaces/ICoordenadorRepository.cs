using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Repository.Interfaces
{
    public interface ICoordenadorRepository
    {
        Task<IEnumerable<Coordenador>> ListaCoordenadoresAsync();
        Task<Coordenador> ObterCoordenadorAsync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AtualizarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
