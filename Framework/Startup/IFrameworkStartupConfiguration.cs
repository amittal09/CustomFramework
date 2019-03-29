using Framework.Auditing;

namespace Framework.Startup
{
    public interface IFrameworkStartupConfiguration
    {
        IAuditingConfiguration Auditing { get; }

    }
}
