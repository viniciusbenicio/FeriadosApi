using FeriadoApi.Entities;

namespace FeriadoApi.Repository
{
    public interface IFeriadoRepository
    {
        Task<Feriado> Salvar(Feriado f);
    }
}
