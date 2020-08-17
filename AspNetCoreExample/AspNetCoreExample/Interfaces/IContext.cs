using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExample.Interfaces
{
    public interface IContext
    {
        public Int32 GetValue();
        public void IncreaseValue(Int32 INT32_Value);
    }
}
