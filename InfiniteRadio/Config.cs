using System.ComponentModel;
using Qurre.API.Addons;

namespace InfiniteRadio
{
    public class Config : IConfig
    {
        [Description("Plugin Name")]
        public string Name { get; set; } = "InfiniteRadio";

        [Description("Enable the plugin?")]
        public bool IsEnable { get; set; } = true;
    }
}
