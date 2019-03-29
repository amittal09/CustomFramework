using Framework.Modules;
using System;
using System.Reflection;

namespace Framework
{
    public class FrameworkBootStrapper :IDisposable
    {
        public Type StartupModule { get; set; }

        protected bool IsDisposed;

        private FrameworkBootStrapper(Type startupModule, Action<FrameworkBootstrapperOptions> optionsAction)
        {
            StartupModule = startupModule;
            var options = new FrameworkBootstrapperOptions();
            optionsAction?.Invoke(options);
        }

        public static FrameworkBootStrapper Create<TStartupModule>(Action<FrameworkBootstrapperOptions> optionsAction = null)
            where TStartupModule : FrameworkModule
        {
            return new FrameworkBootStrapper(typeof(TStartupModule), optionsAction);
        }
        public static FrameworkBootStrapper Create(Type startupModule,Action<FrameworkBootstrapperOptions> optionsAction = null)
        {
            if (!typeof(FrameworkModule).GetTypeInfo().IsAssignableFrom(startupModule))
            {
                throw new ArgumentException($"{nameof(startupModule)} should be derived from {nameof(FrameworkModule)}.");
            }
            
            return new FrameworkBootStrapper(startupModule, optionsAction);
        }

        public virtual void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            IsDisposed = true;

            //_moduleManager?.ShutdownModules();
        }
    }
}
