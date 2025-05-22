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

        public async Task AtualizarAsync(Coordenador coordenador)
        {
            await _coordenadorRepository.AtualizarAsync(coordenador);
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coordenador>> ListaCoordenadorsAsync()
        {
            return await _coordenadorRepository.ListaCoordenadoresAsync();
        }

        public async Task<Coordenador> ObterCoordenadorAsync(int id)
        {
            var coordenador = await _coordenadorRepository.ObterCoordenadorAsync(id);
            if (coordenador == null)
            {
                throw new KeyNotFoundException($"O coordenador com id {id} não foi localizado");
            }
            return coordenador;
        }
    }
}
