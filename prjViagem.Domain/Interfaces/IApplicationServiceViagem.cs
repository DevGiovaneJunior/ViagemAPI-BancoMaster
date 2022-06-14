using prjViagem.Domain.DTOs;

namespace prjViagem.Domain.Interfaces
{
    public interface IApplicationServiceViagem
    {
        void Add(ViagemRequestDTO obj);

        ViagemDTO GetById(int id);
        ViagemDTO GetDestino(string origem, string destino);

        IEnumerable<ViagemDTO> GetAll();

        void Update(ViagemDTO obj);

        void Remove(ViagemDTO obj);
        void Dispose();
    }
}
