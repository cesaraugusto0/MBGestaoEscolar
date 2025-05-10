using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> ListaAlunosAsync();
        Task<Aluno> ObterAlunoAsync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AtualizarAsync(Aluno aluno);
        Task ExcluirAsync(int id);
    }
}
