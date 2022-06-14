using prjViagem.Domain.Interfaces;
using prjViagem.Infrastructure.Entities;
using prjViagem.Infrastructure.Interfaces;

namespace prjViagem.Domain.Services
{
    public class ServiceViagem : ServiceBase<Viagem>, IServiceViagem
    {
        public readonly IRepositoryViagem _repositoryViagem;
        public ServiceViagem(IRepositoryViagem repositoryViagem)
            : base(repositoryViagem)
        {
            _repositoryViagem = repositoryViagem;
        }
        public new virtual void Add(Viagem obj)
        {
            _repositoryViagem.Add(obj);
        }

        public new virtual Viagem GetDestino(string origem, string destino)
        {
            return _repositoryViagem.GetDestino(origem, destino);
        }
        public new virtual Viagem GetById(int id)
        {
            return _repositoryViagem.GetById(id);
        }
        public new virtual IEnumerable<Viagem> GetAll()
        {
            return _repositoryViagem.GetAll();
        }
        public new virtual void Update(Viagem obj)
        {
            _repositoryViagem.Update(obj);
        }
        public new virtual void Remove(Viagem obj)
        {
            _repositoryViagem.Remove(obj);
        }
        public new virtual void Dispose()
        {
            _repositoryViagem.Dispose();
        }
    }
}
