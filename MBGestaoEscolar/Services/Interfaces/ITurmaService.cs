using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Services.Interfaces
{
    public interface ITurmaService
    {
        Task<IEnumerable<Turma>> ListaTurmasAsync();
        Task<Turma> ObterTurmaAsync(int id);
        Task AdicionarAsync(Turma turma);
        Task AtualizarAsync(Turma turma);
        Task ExcluirAsync(int id);
    }
}
