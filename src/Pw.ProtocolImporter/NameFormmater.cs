using System;
using System.Linq;
using Humanizer;

namespace Pw.ProtocolImporter
{
    public static class NameFormatter
    {
        private static readonly string[] Words = {"id", "arg", "res", "role", "name", "code", "freq", "data"};

        public static string ToCamelCase(string name)
        {
            name = ReplacePostfix(name);
            name = name.Replace("_", " ");
            name = name.Transform(To.LowerCase);
            name = name.Transform(To.TitleCase);
            name = name.Pascalize();
            return name;
        }

        public static string ReplacePostfix(string name)
        {
            var postfix = FindPostfix();

            if (postfix == null)
            {
                return name;
            }
            else
            {
                name = name.Substring(0..^postfix.Length);
                name = ReplacePostfix(name);
                return $"{name}_{postfix}";
            }

            string FindPostfix() => Words.FirstOrDefault(p => name.EndsWith(p, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
