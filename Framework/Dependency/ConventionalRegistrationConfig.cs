﻿namespace Framework.Dependency
{
    public class ConventionalRegistrationConfig
    {
        public bool InstallInstallers { get; set; }
        public ConventionalRegistrationConfig()
        {
            InstallInstallers = true;
        }
    }
}