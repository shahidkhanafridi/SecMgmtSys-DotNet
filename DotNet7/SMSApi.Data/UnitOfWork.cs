using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
    }
}
