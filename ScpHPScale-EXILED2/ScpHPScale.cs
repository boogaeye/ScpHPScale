using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.Handlers;
using Exiled.API.Features;
using Exiled.API.Enums;

namespace ScpHPScale_EXILED2
{
    public class ScpHPScale : Plugin<Config>
    {
        private static readonly Lazy<ScpHPScale> LazyInstance = new Lazy<ScpHPScale>( valueFactory: () => new ScpHPScale());
        static public ScpHPScale instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.First;
        private Handlers.Player player;
        private ScpHPScale()
        {

        }
        public override void OnEnabled()
        {
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            Log.Info("Registered");
            player = new Handlers.Player();
            Exiled.Events.Handlers.Player.ChangingRole += player.OnRoleChange;
            Exiled.Events.Handlers.Player.Spawning += player.Spawn;
            Exiled.Events.Handlers.Player.Joined += player.Join;
            Exiled.Events.Handlers.Player.Left += player.Leave;
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= player.OnRoleChange;
            Exiled.Events.Handlers.Player.Spawning -= player.Spawn;
            Exiled.Events.Handlers.Player.Joined -= player.Join;
            Exiled.Events.Handlers.Player.Left -= player.Leave;
        }
    }
}
