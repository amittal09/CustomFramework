using Framework.Modules;

namespace CustomConsole
{
    public class MyStartupClass : FrameworkModule
    {
        public MyStartupClass()
        {
            Configuration.Auditing.IsEnabled = false;
            Configuration.Auditing.IsEnabledForAnonymousUsers = false;
        }
    }
}
