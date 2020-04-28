namespace Pw.GdbTypeImporter
{
    public static class CppTerms
    {
        public static readonly string CharType = "char";
        public static readonly string FloatType = "float";
        public static readonly string NameCharType = "namechar";
        public static readonly string IntType = "int";
        public static readonly string UIntType = "unsigned int";
        public static readonly string ULongType = "unsigned long";

        public static readonly string[] DefaultTypes = {CharType, FloatType, NameCharType, IntType, UIntType};

        public static readonly string UnsignedPrefix = "unsigned";
        public static readonly string AnonymousStructDefinition = "struct";
    }
}
