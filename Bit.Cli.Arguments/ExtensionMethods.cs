using System.Collections.Generic;

namespace Bit.Cli.Arguments
{
    public static class ExtensionMethods
    {
        public static void Execute(this IList<Option> options, string[] args)
        {
            foreach (var option in options)
            {
                option.Action(true);
            }

        }
    }
}
