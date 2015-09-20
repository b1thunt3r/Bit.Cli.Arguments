using System;
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

        public static void PrintHelp(this IList<Option> options)
        {
            foreach (var option in options)
            {
                if (string.IsNullOrWhiteSpace(option.ShortName) && !string.IsNullOrWhiteSpace(option.LongName))
                {
                    Console.WriteLine("", option.ShortName);
                }
                else if (!string.IsNullOrWhiteSpace(option.ShortName) && string.IsNullOrWhiteSpace(option.LongName))
                {

                    Console.WriteLine("", option.LongName);
                }
                else if (!string.IsNullOrWhiteSpace(option.ShortName) && !string.IsNullOrWhiteSpace(option.LongName))
                {

                    Console.WriteLine("", option.ShortName, option.LongName);
                }
            }
        }

        public static void Execute(this IList<Option> options, string[] args)
        {
            foreach (var s in args)
            {
                if (s.StartsWith("--"))
                {
                    var arg = s.Substring(2).Split("=:".ToCharArray());
                    if (arg.Length != 2) continue;

                    if (arg[0].ToUpper().Equals("HELP"))
                    {
                        options.PrintHelp();
                        break;
                    }

                    var name = options.FindWithLongtName(arg[0]);
                    if (name != null) ;
                }
                else if (s.StartsWith("-"))
                {
                    var name = options.FindWithShortName(s.Substring(1));
                    if (name != null) ;
                }
                else if (s.StartsWith("/"))
                {
                    //?
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
