using NossaLoja.Cadastros.Domain.Interface;

namespace NossaLoja.Cadastros.Domain.Service
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public int SomaUmMaisUm()
        {
            int valor1 = _clienteRepository.GetNumeroUm();
            int valor2 = _clienteRepository.GetNumeroUm();

            return valor1 + valor2;
        }
    
    }
}
