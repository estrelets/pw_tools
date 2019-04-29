namespace Pw.Configuration
{
    public static class ConfigurationReaderExtensions
    {
        //Uses type name as section name
        public static TSection Read<TSection>(this IConfigurationReader reader)
            where TSection : IConfigurationSection
        {
            return reader.Read<TSection>(typeof(TSection).Name);
        }
    }
}