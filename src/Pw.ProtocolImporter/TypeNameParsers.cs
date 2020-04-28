using System;
using System.Linq;
using Sprache;

namespace Pw.ProtocolImporter
{
    public class TypeNameParsers
    {
        private Parser<IOption<char>> OptionalWhiteSpace => Parse.Char(Char.IsWhiteSpace, "").Optional();
        private Parser<IOption<string>> OptionalUnsignedPrefix => Parse.String("unsigned").Text().Optional();

        private Parser<string> TypeNameParser =>
            Parse.Char(c => Char.IsLetterOrDigit(c) || c == '_' || c == ':', "").AtLeastOnce().Text();

        private Parser<BaseType> GenericOrSimpleTypeDeclaration => GenericTypeDeclaration.Or(SimpleTypeDeclaration);

        private Parser<BaseType> SimpleTypeDeclaration =>
            from unsignedPrefix in OptionalUnsignedPrefix
            from space in Parse.WhiteSpace.Optional()
            from type in TypeNameParser
            select new SimpleType(unsignedPrefix.IsEmpty ? type : $"{unsignedPrefix.Get()} {type}");

        private Parser<BaseType> GenericTypeDeclaration =>
            from type in SimpleTypeDeclaration
            from openParameters in Parse.Char('<')
            from _ in OptionalWhiteSpace
            from inner in GenericOrSimpleTypeDeclaration.DelimitedBy(Parse.Char(','))
            from _2 in OptionalWhiteSpace
            from closeParameters in Parse.Char('>')
            select new GenericType(type, inner.ToArray());

        public BaseType ParseType(string input)
        {
            return GenericOrSimpleTypeDeclaration.Parse(input);
        }
    }
}
