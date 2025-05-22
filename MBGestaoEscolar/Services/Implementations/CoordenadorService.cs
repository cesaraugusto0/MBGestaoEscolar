using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Interfaces;

namespace MBGestaoEscolar.Services.Implementations
{
    public class CoordenadorService : ICoordenadorService
    {
        private readonly ICoordenadorRepository _coordenadorRepository;

        public CoordenadorService(ICoordenadorRepository coordenadorRepository)
        {
            _coordenadorRepository = coordenadorRepository;
        }
        
        public async Task AdicionarAsync(Coordenador coordenador)
        {
            await _coordenadorRepository.AdicionarAsync(coordenador);
        }

        public Task AtualizarAsync(Coordenador coordenador)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coordenador>> ListaCoordenadorsAsync()
        {
            return await _coordenadorRepository.ListaCoordenadoresAsync();
        }

        public Task<Coordenador> ObterCoordenadorAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
