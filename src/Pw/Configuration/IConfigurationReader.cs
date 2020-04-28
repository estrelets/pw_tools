namespace Pw.Configuration
{
    public interface IConfigurationReader
    {
        TSection Read<TSection>(string name) where TSection : IConfigurationSection;
    }
}
