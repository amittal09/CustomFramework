using System.Reflection;

namespace Framework.Dependency
{
    public class ConventionalRegistrationContext : IConventionalRegistrationContext
    {

        public Assembly Assembly { get; }
        public IIocManager IocManager { get; }
        public ConventionalRegistrationConfig Config { get; }

        public ConventionalRegistrationContext(Assembly assembly, IocManager iocManager, ConventionalRegistrationConfig config)
        {
            Assembly = assembly;
            IocManager = iocManager;
            Config = config;
        }
    }
}