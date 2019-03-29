using Castle.Windsor;
using System;

namespace Framework.Dependency
{
    public interface IIocManager : IIocRegistrar, IIocResolver, IDisposable
    {
        IWindsorContainer IocContainer { get; }

        new bool IsRegistered(Type type);

        new bool IsRegistered<T>();
    }
}
