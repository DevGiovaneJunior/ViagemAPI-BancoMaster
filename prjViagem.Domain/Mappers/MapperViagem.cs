using prjViagem.Domain.DTOs;
using prjViagem.Domain.Mappers.Interface;
using prjViagem.Infrastructure.Entities;

namespace prjViagem.Domain.Mappers
{
    public class MapperViagem : IMapperViagem
    {
        #region properties

        public List<ViagemDTO> viagemsDTOs = new List<ViagemDTO>();

        #endregion

        #region methods

        public Viagem MapperToEntity(ViagemDTO ViagemDTO)
        {
            Viagem viagem = new Viagem
            {
                Id = ViagemDTO.Id,
                Origem = ViagemDTO.Origem,
                Destino = ViagemDTO.Destino,
                Rota = ViagemDTO.Rota,
                Custo = ViagemDTO.Custo,
            };
            return viagem;
        }
        public Viagem MapperToEntityRequest(ViagemRequestDTO ViagemDTO)
        {
            Viagem viagem = new Viagem
            {
                Id = ViagemDTO.Id,
                Origem = ViagemDTO.Origem,
                Destino = ViagemDTO.Destino,
                Rota = ViagemDTO.Rota,
                Custo = ViagemDTO.Custo,
            };
            return viagem;
        }

        public IEnumerable<ViagemDTO> MapperListViagems(IEnumerable<Viagem> Viagem)
        {
            foreach (var item in Viagem)
            {
                ViagemDTO viagemDTO = new ViagemDTO
                {
                    Id = item.Id,
                    Origem = item.Origem,
                    Destino = item.Destino,
                    Rota = item.Rota,
                    Custo = item.Custo,
                };
                viagemsDTOs.Add(viagemDTO);
            }
            return viagemsDTOs;
        }

        public ViagemDTO MapperToDTO(Viagem viagems)
        {
            ViagemDTO ViagemDTO = new ViagemDTO
            {
                Id = viagems.Id,
                Origem = viagems.Origem,
                Destino = viagems.Destino,
                Rota = viagems.Rota,
                Custo = viagems.Custo,
            };
            return ViagemDTO;
        }

        #endregion
    }
}
