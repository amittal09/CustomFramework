using System.Reflection;

namespace Framework.Dependency
{
    public interface IConventionalDependencyRegistrar
    {
        void RegisterAssembly(IConventionalRegistrationContext context);
    }
}