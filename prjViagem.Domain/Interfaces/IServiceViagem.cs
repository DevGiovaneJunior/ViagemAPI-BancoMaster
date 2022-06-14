using prjViagem.Infrastructure.Entities;

namespace prjViagem.Domain.Interfaces
{
    public interface IServiceViagem
    {
        void Add(Viagem obj);

        Viagem GetById(int id);
        Viagem GetDestino(string origem, string destino);

        IEnumerable<Viagem> GetAll();

        void Update(Viagem obj);

        void Remove(Viagem obj);

        void Dispose();
    }
}
