using System.Reflection;

namespace Framework.Dependency
{
    public interface IConventionalRegistrationContext
    {
        Assembly Assembly { get; }
        IIocManager IocManager { get; }
        ConventionalRegistrationConfig Config { get; }
    }
}