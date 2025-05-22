using MBGestaoEscolar.Data.Context;
using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolar.Repository.Implementation
{
    public class CoordenadorRepository:ICoordenadorRepository
    {
        private readonly SQLServerDBContext _context;

        public CoordenadorRepository(SQLServerDBContext context)
        {
            _context = context;
        }

        public async Task<Coordenador> ObterCoordenadorAsync(int id)
        {
            return await _context.Coordenadores.FindAsync(id);
        }

        public async Task AdicionarAsync(Coordenador coordenador)
        {
            await _context.Coordenadores.AddAsync(coordenador);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Coordenador coordenador)
        {
            _context.Coordenadores.Update(coordenador);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var coordenadorExcluir = await _context.Coordenadores.FindAsync(id);
            if (coordenadorExcluir != null)
            {
                _context.Coordenadores.Remove(coordenadorExcluir);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Coordenador>> ListaCoordenadoresAsync()
        {
            return await _context.Coordenadores.ToListAsync();
        }
    }
}
