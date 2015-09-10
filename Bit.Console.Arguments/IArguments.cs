
using System.Collections.Generic;

namespace Bit.Console.Arguments
{
    public interface IArguments
    {
        IList<Option> Options { get; }
    }
}
