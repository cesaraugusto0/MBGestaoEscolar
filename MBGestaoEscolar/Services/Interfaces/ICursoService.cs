using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Services.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> ListaCursosAsync();
        Task<Curso> ObterCursoAsync(int id);
        Task AdicionarAsync(Curso curso);
        Task AtualizarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
