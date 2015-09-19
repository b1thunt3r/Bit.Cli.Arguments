using System.Collections.Generic;
using System.Linq;

namespace Bit.Cli.Arguments
{
    public static class ExtensionMethods
    {

        public static Option FindWithShortName(this IList<Option> options, string arg)
        {
            return options.FirstOrDefault(o => o.ShortName == arg);
        }

        public static Option FindWithLongtName(this IList<Option> options, string arg)
        {
            return options.FirstOrDefault(o => o.LongName == arg);
        }

        public static void Execute(this IList<Option> options, string[] args)
        {
            foreach (var s in args)
            {
                if (s.StartsWith("--"))
                {
                    var arg = s.Split("=:".ToCharArray());
                    if (arg.Length != 2) continue;

                    var name = options.FindWithLongtName(arg[0].Substring(2));
                    if (name != null) ;
                }
                else if (s.StartsWith("-"))
                {
                    var name = options.FindWithShortName(s.Substring(1));
                    if (name != null) ;
                }
                else if (s.StartsWith("/"))
                {

                }
                else
                {

                }
            }

            //foreach (var option in options)
            //{
            //    if ((option.Type & OptionType.Flag) == OptionType.Flag)
            //    {
            //        var flag = args.FirstOrDefault(x => x.Contains(option.ShortName) || x.Contains(option.LongName));
            //        if (flag != null)
            //            option.Action(true);
            //    }
            //}

        }
    }
}
