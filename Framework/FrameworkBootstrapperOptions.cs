using Framework.Dependency;

namespace Framework
{
    public class FrameworkBootstrapperOptions
    {
        public bool DisableAllInterceptors { get; set; }

        public IIocManager IocManager { get; set; }

        //public PlugInSourceList PlugInSources { get; }

        public FrameworkBootstrapperOptions()
        {
            IocManager = Dependency.IocManager.Instance;
            //PlugInSources = new PlugInSourceList();
        }

    }
}