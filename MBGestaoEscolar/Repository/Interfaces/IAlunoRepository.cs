using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> ListaAlunosAsync();
        Task<Aluno> ObterAlunoAsync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AtualizarAsync(Aluno aluno);
        Task ExcluirAsync(int id);
    }
}
