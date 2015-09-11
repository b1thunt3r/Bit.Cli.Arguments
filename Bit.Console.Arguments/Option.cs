using System;

namespace Bit.Cli.Arguments
{
    public class Option
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public Action<object> Action { get; set; }
        public string Description { get; set; }
        public OptionType Type { get; set; }
    }
}
