using Pw.Bootstrapper.Tasks;
using YamlDotNet.Serialization;

namespace Pw.Bootstrapper.Configuration
{
    public static class YamlConfigurationCustomization
    {
        public static void RegisterTags(DeserializerBuilder builder)
        {
            builder.WithTagMapping("!run", typeof(RunExecutableTask));
            builder.WithTagMapping("!command", typeof(RunCommandTask));
            builder.WithTagMapping("!kill", typeof(KillProcessTask));
        }
    }
}
