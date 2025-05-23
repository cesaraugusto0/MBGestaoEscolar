using MBGestaoEscolar.Data.Context;
using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolar.Repository.Implementation
{
    public class CursoRepository:ICursoRepository
    {
        private readonly SQLServerDBContext _context;

        public CursoRepository(SQLServerDBContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Curso>> ListaCursosAsync()
        {
            return await _context.Cursos.ToListAsync();
        }

        public Task<Curso> ObterCursoAsync(int id)
        {
            throw new NotImplementedException();
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
    }
}

