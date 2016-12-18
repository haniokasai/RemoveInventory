using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Plugins.Commands;
using MiNET;
using log4net;

namespace RemoveInventory
{
    [Plugin(PluginName = "RemoveInventory", Description = "Remove Inventory for MiNET", PluginVersion = "1.0", Author = "haniokasai")]
    public class RemoveInventory : Plugin
    {
        protected static ILog _log = LogManager.GetLogger("RemoveInventory");
        protected override void OnEnable()
        {
            _log.Warn("Loaded");
        }

        [Command(Name = "ri", Description = "Remove your Inventory", Permission = "com.haniokasai.RemoveInventory")]
        public void ri(Player player)
        {
            player.Inventory.Clear();
            player.SendMessage("Removed items from your Inventory!");
        }

    }
}
