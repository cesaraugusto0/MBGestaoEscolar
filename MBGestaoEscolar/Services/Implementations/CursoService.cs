using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Interfaces;

namespace MBGestaoEscolar.Services.Implementations
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        
        public Task AdicionarAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Curso>> ListaCursosAsync()
        {
            return await _cursoRepository.ListaCursosAsync();
        }

        public Task<Curso> ObterCursoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
