using FeriadoApi.Context;
using FeriadoApi.Entities;
using Microsoft.EntityFrameworkCore;
using static FeriadoApi.Repository.FeriadoRepository;

namespace FeriadoApi.Repository
{

    public class FeriadoRepository : IFeriadoRepository
    {

        private readonly FeriadoContext _context;
        private readonly IFeriadoRepository _repository;

        public FeriadoRepository(FeriadoContext context)
        {
            _context = context;
        }

        public async Task<Feriado> Salvar(Feriado f)
        {
            await _context.AddAsync(f);
            await _context.SaveChangesAsync();

            return f;
        }

    }
}
