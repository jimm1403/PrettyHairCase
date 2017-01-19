using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLayer
{
    public interface IKeyGenerator
    {
        string NextKey { get; }
    }
}
