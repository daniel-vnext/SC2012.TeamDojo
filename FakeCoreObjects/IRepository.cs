using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeCoreObjects
{
    public interface IRepository
    {

        IEnumerable<T> GetAll<T>();

    }
}
