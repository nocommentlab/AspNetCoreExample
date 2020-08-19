using System;
using AspNetCoreExample.Interfaces;

namespace AspNetCoreExample.Services
{
    public class ScopedService:IScopedService
    {
        public ScopedService()
        {
            InstanceGuid = Guid.NewGuid();
        }

        public Guid InstanceGuid { get; }
    }
}
