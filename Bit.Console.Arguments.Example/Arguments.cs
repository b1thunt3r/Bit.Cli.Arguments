

namespace Bit.Console.Arguments.Example
{
    public class Arguments : IArguments
    {
        public bool Bool { get; set; }
        public string String { get; set; }
        public int Integer { get; set; }

        public Options Options { get; set; }
    }
}
