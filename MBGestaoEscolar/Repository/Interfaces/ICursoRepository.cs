using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Repository.Interfaces
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Curso>> ListaCursosAsync();
        Task<Curso> ObterCursoAsync(int id);
        Task AdicionarAsync(Curso curso);
        Task AtualizarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
