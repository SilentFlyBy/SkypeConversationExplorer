using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Core.Interfaces
{
    public interface ISCERepositoryFactory
    {
        T CreateRepository<T>() where T : class;
    }
}
