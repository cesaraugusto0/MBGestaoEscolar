using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Interfaces;

namespace MBGestaoEscolar.Services.Implementations
{
    public class InstrutorService : IInstrutorService
    {
        private readonly IInstrutorRepository _instrutorRepository;

        public InstrutorService(IInstrutorRepository instrutorRepository)
        {
            _instrutorRepository = instrutorRepository;
        }

        public async Task AdicionarAsync(Instrutor instrutor)
        {
            if (string.IsNullOrEmpty(instrutor.Nome))
            {
                throw new ArgumentNullException("O nome é obrigatório!");
            }
            await _instrutorRepository.AdicionarAsync(instrutor);
        }

        public async Task AtualizarAsync(Instrutor instrutor)
        {
            await _instrutorRepository.AtualizarAsync(instrutor);
        }

        public async Task ExcluirAsync(int id)
        {
            await _instrutorRepository.ExcluirAsync(id);
        }

        public async Task<IEnumerable<Instrutor>> ListarInstrutoresAsync()
        {
            return await _instrutorRepository.ListaInstrutoresAsync();
        }

        public async Task<Instrutor> ObterInstrutorAsync(int id)
        {
            var instrutor = await _instrutorRepository.ObterInstrutorAsync(id);
            if (instrutor == null)
            {
                throw new KeyNotFoundException($"O instrutor com id {id} não foi localizado");
            }
            return instrutor;
        }
    }
}