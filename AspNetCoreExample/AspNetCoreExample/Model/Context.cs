using AspNetCoreExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExample.Model
{
    public class Context : IContext
    {
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
