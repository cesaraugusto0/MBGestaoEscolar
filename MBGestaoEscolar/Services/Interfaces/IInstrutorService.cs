using MBGestaoEscolar.Entities;

namespace MBGestaoEscolar.Services.Interfaces
{
    public interface IInstrutorService
    {
        Task<IEnumerable<Instrutor>> ListaInstrutorsAsync();
        Task<Instrutor> ObterInstrutorAsync(int id);
        Task AdicionarAsync(Instrutor instrutor);
        Task AtualizarAsync(Instrutor instrutor);
        Task ExcluirAsync(int id);
    }
}
