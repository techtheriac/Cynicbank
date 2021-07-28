using System;
using System.Collections.Generic;
using System.Text;

namespace CynicBank.Core.Interfaces
{
    public interface IFileReader<T>
    {
        List<T> ReadFile(string filepath);
    }
}
