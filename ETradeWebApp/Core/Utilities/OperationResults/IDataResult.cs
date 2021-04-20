using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.OperationResults
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
