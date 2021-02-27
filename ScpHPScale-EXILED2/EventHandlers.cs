using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace ScpHPScale_EXILED2
{
    public class EventHandlers
    {
        private readonly ScpHPScale plugin;
        public EventHandlers(ScpHPScale scpHPScale) => this.plugin = plugin;
        public Config config = ScpHPScale.instance.Config;
        public List<Player> playerList = new List<Player>() { };
        public void Join(VerifiedEventArgs ev)
        {
            playerList.Add(ev.Player);
        }
        public void Leave(DestroyingEventArgs ev)
        {
            playerList.Remove(ev.Player);
        }
        public void OnRoleChange(ChangingRoleEventArgs ev)
        {
            Task.Delay(3000).ContinueWith(t => DelayedRoleChange(ev));
        }
        void DelayedRoleChange(ChangingRoleEventArgs ev)
        {
            if (config.Allow0492HPScale && ev.Player.Role == RoleType.Scp0492)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp0492HpCap > hp * config.Scp0492HpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp0492HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp0492HpCap;
                }
            }
            if (config.Allow049HPScale && ev.Player.Role == RoleType.Scp049)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp049HpCap > hp * config.Scp049HpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp049HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp049HpCap;
                }
            }
            if (config.Allow096HPScale && ev.Player.Role == RoleType.Scp096)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp096HpCap > hp * config.Scp096HpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp096HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp096HpCap;
                }
            }
            if (config.Allow173HPScale && ev.Player.Role == RoleType.Scp173)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp096HpCap > hp * config.Scp173HpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp173HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp173HpCap;
                }
            }
            if (config.Allow106HPScale && ev.Player.Role == RoleType.Scp106)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp106HpCap > hp * config.Scp106HpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp106HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp106HpCap;
                }
            }
            if (config.Allow939HPScale && ev.Player.Role == RoleType.Scp93953)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp939sHpCap > hp * config.Scp939sHpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp939sHpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp939sHpCap;
                }
            }
            if (config.Allow939HPScale && ev.Player.Role == RoleType.Scp93989)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (config.Scp939sHpCap > hp * config.Scp939sHpScaleAdd)
                {
                    ev.Player.Health = hp * config.Scp939sHpScaleAdd;
                }
                else
                {
                    ev.Player.Health = config.Scp939sHpCap;
                }
            }
        }
    }
}
