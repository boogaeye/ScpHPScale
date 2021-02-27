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
        public EventHandlers EventHandlers;
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
            EventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Player.ChangingRole += EventHandlers.OnRoleChange;
            Exiled.Events.Handlers.Player.Verified += EventHandlers.Join;
            Exiled.Events.Handlers.Player.Destroying += EventHandlers.Leave;        
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= EventHandlers.OnRoleChange;
            Exiled.Events.Handlers.Player.Verified -= EventHandlers.Join;
            Exiled.Events.Handlers.Player.Destroying -= EventHandlers.Leave;
        }
    }
}
