using NossaLoja.Cadastros.Domain.Interface;
using NossaLoja.Cadastros.Domain.Service;
using NossaLoja.Cadastros.Infra.DependencyInjection.Services;
using System.Runtime.CompilerServices;

namespace NossaLoja.Cadastros.Application.Application
{
    public class ClienteApplication
    {
        private ClienteService ServiceFactory()
        {
            var clienteService = new ClienteService(
                   DependecyInjectionService.Resolve<IClienteRepository>()
                );
            return clienteService;
        }

        public int SomaMaisUm()
        {
            var resultado = ServiceFactory().SomaUmMaisUm();

            return resultado;
        }

    }
}
