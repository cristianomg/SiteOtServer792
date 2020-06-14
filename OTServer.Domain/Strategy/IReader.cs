using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Strategy
{
    public interface IReader<T>
    {
        List<T> ReaderFiles(string directory);
    }
}
