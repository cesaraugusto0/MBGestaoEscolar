using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Repository.Interfaces
{
    public interface IInstrutorRepository
    {
        Task<IEnumerable<Instrutor>> ListaInstrutorsAsync();
        Task<Instrutor> ObterInstrutorAsync(int id);
        Task AdicionarAsync(Instrutor instrutor);
        Task AtualizarAsync(Instrutor instrutor);
        Task ExcluirAsync(int id);
    }
}
