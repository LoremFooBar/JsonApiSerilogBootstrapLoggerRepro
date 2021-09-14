using JsonApiDotNetCore.Resources;

namespace JsonApiSerilogBootstrapLoggerRepro.Model
{
    public class Contact : Identifiable
    {
        public string Name { get; set; }
    }
}
