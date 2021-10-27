using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Interfaces
{
    public interface IService<T>
    {
        IDictionary<string, object> GetAttributes(T obj);
    }
}
