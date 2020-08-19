using System;
using AspNetCoreExample.Interfaces;

namespace AspNetCoreExample.Services
{
    public class TransientService:ITransientService
    {
        public TransientService()
        {
            InstanceGuid = Guid.NewGuid();
        }

        public Guid InstanceGuid { get; }
    }
}
