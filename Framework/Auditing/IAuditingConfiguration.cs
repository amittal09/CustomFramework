using System;
using System.Collections.Generic;

namespace Framework.Auditing
{
    public interface IAuditingConfiguration
    {
        bool IsEnabled { get; set; }

        bool IsEnabledForAnonymousUsers { get; set; }

        //IAuditingSelectorList Selectors { get; }

        List<Type> IgnoredTypes { get; }

        bool SaveReturnValues { get; set; }
    }
}
