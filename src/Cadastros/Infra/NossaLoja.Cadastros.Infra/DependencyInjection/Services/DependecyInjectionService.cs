using NossaLoja.Cadastros.Infra.DependencyInjection.Interfaces;
using Unity;

namespace NossaLoja.Cadastros.Infra.DependencyInjection.Services
{
    public static class DependecyInjectionService
    {
        private static IDependecyInjection _dependecyInjection;

        public static void Inicializa(IDependecyInjection dependecyInjection)
        {
            _dependecyInjection = dependecyInjection;
        }

        public static T Resolve<T>() => _dependecyInjection.Resolve<T>();
        public static T Resolve<T>(string name) => _dependecyInjection.Resolve<T>(name);
        public static T Resolve<T>(Type type) => _dependecyInjection.Resolve<T>(type);
    }
}
