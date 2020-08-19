using AspNetCoreExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExample.Model
{
    public class Context : IContext
    {
        public Context(IScopedService scoped, ITransientService transient)
        {
            Console.Write($"transient service guid in controller is {transient.InstanceGuid}");
            Console.Write($"scoped service guid in controller is {scoped.InstanceGuid}");
        }

        #region Members
        private Int32 _INT32_Value;
        #endregion
        public int GetValue()
        {
            return _INT32_Value;
        }

        public void IncreaseValue(int INT32_Value)
        {
            _INT32_Value += INT32_Value;
        }
    }
}
