using System.IO;
using System.Reflection;

namespace Tests.Common
{
    public static class EmbeddedResourceGetter
    {
        public static StreamReader GetReaderForResource(string resourceName)
        {
            var assembly = Assembly.GetCallingAssembly();
            var stream = assembly.GetManifestResourceStream(resourceName);
            return new StreamReader(stream);
        }

        public static Stream GetResourceStream(string resourceName)
        {
            var assembly = Assembly.GetCallingAssembly();
            return assembly.GetManifestResourceStream(resourceName);
        }
    }
}
