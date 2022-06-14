using Autofac;
using prjViagem.Domain.Interfaces;
using prjViagem.Domain.Mappers;
using prjViagem.Domain.Mappers.Interface;
using prjViagem.Domain.Services;
using prjViagem.Infrastructure.Interfaces;
using prjViagem.Infrastructure.Repositories;

namespace prjViagem.Configuration
{
    public static class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceViagem>().As<IApplicationServiceViagem>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceViagem>().As<IServiceViagem>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryViagem>().As<IRepositoryViagem>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperViagem>().As<IMapperViagem>();
            #endregion

            #endregion
        }

    }
}
