using System.Collections.Generic;

namespace Bit.Console.Arguments
{
    public class Options : ICollection<Option>
    {
    }

    public class Option
    {
        public string ShortName { get; set; }
    }
}
