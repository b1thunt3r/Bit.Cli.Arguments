
using System.Collections.Generic;

namespace Bit.Cli.Arguments
{
    public interface IArguments
    {
        IList<Option> Options { get; }
    }
}
