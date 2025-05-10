using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Repository.Interfaces
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> ListaTurmasAsync();
        Task<Turma> ObterTurmaAsync(int id);
        Task AdicionarAsync(Turma turma);
        Task AtualizarAsync(Turma turma);
        Task ExcluirAsync(int id);
    }
}
