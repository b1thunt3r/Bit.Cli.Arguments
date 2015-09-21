using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bit.Cli.Arguments
{
    public class OptionSet
    {
        private readonly IList<Option> _options = new List<Option>();
        public IList<Option> Options
        {
            get { return _options; }
        }

        private readonly StringBuilder _helpTextPrefix = new StringBuilder();
        public StringBuilder HelpTextPrefix
        {
            get { return _helpTextPrefix; }
        }

        private readonly StringBuilder _helpTextSuffix = new StringBuilder();
        public StringBuilder HelpTextSuffix
        {
            get { return _helpTextSuffix; }
        }

        public void PrintHelpText()
        {
            Console.WriteLine(HelpTextPrefix.ToString());

            Console.WriteLine("Options:");
            foreach (var option in Options)
            {
                string optStr = "";
                if (string.IsNullOrWhiteSpace(option.ShortName) && !string.IsNullOrWhiteSpace(option.LongName))
                {
                    optStr = "-" + option.ShortName;
                }
                else if (!string.IsNullOrWhiteSpace(option.ShortName) && string.IsNullOrWhiteSpace(option.LongName))
                {
                    optStr = "--" + option.LongName;
                }
                else if (!string.IsNullOrWhiteSpace(option.ShortName) && !string.IsNullOrWhiteSpace(option.LongName))
                {
                    optStr = "-" + option.ShortName + ", --" + option.LongName;
                }

                Console.WriteLine("{0,10} {1}", optStr, option.Description);
            }

            Console.WriteLine(HelpTextSuffix.ToString());
        }

        public Option FindWithShortName(string arg)
        {
            return Options.FirstOrDefault(o => o.ShortName == arg);
        }

        public Option FindWithLongtName(string arg)
        {
            return Options.FirstOrDefault(o => o.LongName == arg);
        }
        public void Execute(string[] args)
        {
            foreach (var s in args)
            {
                if (s.StartsWith("--"))
                {
                    var arg = s.Substring(2).Split("=:".ToCharArray());

                    if (arg[0].ToUpper().Equals("HELP"))
                    {
                        PrintHelpText();
                        break;
                    }

                    if (arg.Length != 2) continue;

                    var name = FindWithLongtName(arg[0]);
                    if (name != null) ;
                }
                else if (s.StartsWith("-"))
                {
                    var name = FindWithShortName(s.Substring(1));
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
