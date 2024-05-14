namespace NossaLoja.Cadastros.Infra.DependencyInjection.Interfaces
{
    public interface IDependecyInjection
    {
        T Resolve<T>();
        T Resolve<T>(string nome);
        T Resolve<T>(Type type);
    }
}
