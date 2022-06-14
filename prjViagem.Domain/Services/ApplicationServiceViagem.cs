using prjViagem.Domain.DTOs;
using prjViagem.Domain.Interfaces;
using prjViagem.Domain.Mappers.Interface;

namespace prjViagem.Domain.Services
{
    public class ApplicationServiceViagem : IApplicationServiceViagem
    {
        private readonly IServiceViagem _serviceViagem;
        private readonly IMapperViagem _mapperViagem;
        public ApplicationServiceViagem(IServiceViagem serviceViagem
                                               , IMapperViagem mapperViagem)
        {
            _serviceViagem = serviceViagem;
            _mapperViagem = mapperViagem;
        }
        public void Add(ViagemRequestDTO obj)
        {
            var objViagem = _mapperViagem.MapperToEntityRequest(obj);
            _serviceViagem.Add(objViagem);
        }

        public void Dispose()
        {
            _serviceViagem.Dispose();
        }

        public IEnumerable<ViagemDTO> GetAll()
        {
            var objViagem = _serviceViagem.GetAll();
            return _mapperViagem.MapperListViagems(objViagem);
        }

        public ViagemDTO GetById(int id)
        {
            var objViagem = _serviceViagem.GetById(id);
            return _mapperViagem.MapperToDTO(objViagem);
        }

        public ViagemDTO GetDestino(string origem, string destino)
        {
            var objViagem = _serviceViagem.GetDestino(origem, destino);
            return _mapperViagem.MapperToDTO(objViagem);
        }

        public void Remove(ViagemDTO obj)
        {
            var objViagem = _mapperViagem.MapperToEntity(obj);
            _serviceViagem.Remove(objViagem);
        }

        public void Update(ViagemDTO obj)
        {
            var objViagem = _mapperViagem.MapperToEntity(obj);
            _serviceViagem.Update(objViagem);
        }
    }
}
