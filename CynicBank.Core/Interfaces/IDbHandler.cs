using System;
using System.Collections.Generic;
using System.Text;

namespace CynicBank.Core.Interfaces
{
    public interface IDbHandler<T>
    {
        bool WriteToFile(T model, string filePath);
        List<T> ReadFile(string filePath);
    }
}
