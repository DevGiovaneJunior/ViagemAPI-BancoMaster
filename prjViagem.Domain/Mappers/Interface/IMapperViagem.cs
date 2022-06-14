using prjViagem.Domain.DTOs;
using prjViagem.Infrastructure.Entities;

namespace prjViagem.Domain.Mappers.Interface
{
    public interface IMapperViagem
    {
        #region Mappers

        Viagem MapperToEntity(ViagemDTO ViagemDTO);
        Viagem MapperToEntityRequest(ViagemRequestDTO ViagemDTO);

        IEnumerable<ViagemDTO> MapperListViagems(IEnumerable<Viagem> Viagens);

        ViagemDTO MapperToDTO(Viagem Viagens);

        #endregion
    }
}
