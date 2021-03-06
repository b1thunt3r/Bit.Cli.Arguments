﻿
namespace Bit.Cli.Arguments.Example
{
    public class Arguments : IArguments
    {
        public bool Bool1 { get; set; }
        public bool Bool2 { get; set; }
        public bool Bool3 { get; set; }
        public bool Bool4 { get; set; }

        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String34 { get; set; }

        public int Integer1 { get; set; }
        public int Integer2 { get; set; }
        public int Integer3 { get; set; }
        public int Integer4 { get; set; }

        private readonly OptionSet _optionSet = new OptionSet();

        public OptionSet OptionSet
        {
            get { return _optionSet; }
        }

        public Arguments(string[] args)
        {


            _optionSet.Options.Add(new Option
            {
                ShortName = "b1",
                LongName = "bool1",
                Description = "Bool one",
                Type = OptionType.Flag | OptionType.Required,
                Action = b => Bool1 = (bool)b
            });

            _optionSet.Options.Add(new Option
            {
                ShortName = "b2",
                LongName = "bool2",
                Description = "Bool Two",
                Type = OptionType.Flag | OptionType.Optional,
                Action = b => Bool1 = (bool)b
            });

            _optionSet.Options.Add(new Option
            {
                ShortName = "b3",
                LongName = "bool3",
                Description = "Bool Three",
                Type = OptionType.Flag | OptionType.Required,
                Action = b => Bool1 = (bool)b
            });

            _optionSet.Options.Add(new Option
            {
                ShortName = "b4",
                LongName = "bool4",
                Description = "Bool Four",
                Type = OptionType.Flag | OptionType.Optional,
                Action = b => Bool1 = (bool)b
            });

            _optionSet.Execute(args);
        }
    }
}
