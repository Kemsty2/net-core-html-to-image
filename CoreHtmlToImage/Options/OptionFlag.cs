using System;

namespace CoreHtmlToImage.Options
{
    public class OptionFlag : Attribute
    {
        public string Name { get; }

        public OptionFlag(string name)
        {
            Name = name;
        }
    }
}