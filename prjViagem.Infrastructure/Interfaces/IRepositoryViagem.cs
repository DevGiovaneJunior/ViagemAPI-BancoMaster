using prjViagem.Infrastructure.Entities;

namespace prjViagem.Infrastructure.Interfaces
{
    public interface IRepositoryViagem : IRepositoryBase<Viagem>
    {
        public Viagem GetDestino(string origem, string destino);
    }
}
