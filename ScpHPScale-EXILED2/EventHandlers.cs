using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using MEC;

namespace ScpHPScale_EXILED2
{
    public class EventHandlers
    {
        private readonly Plugin<Config> plugin;
        public EventHandlers(Plugin<Config> plugin) => this.plugin = plugin;
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
            Timing.CallDelayed(this.plugin.Config.Delay, () => {
                if (ev.Player.IsScp)
                {
                    ev.Player.ShowHint(this.plugin.Config.hpChangeHint, 5);
                }
                DelayedRoleChange(ev);
            });
        }
        void DelayedRoleChange(ChangingRoleEventArgs ev)
        {
            if (this.plugin.Config.Allow0492HPScale && ev.Player.Role == RoleType.Scp0492)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp0492HpCap > hp * this.plugin.Config.Scp0492HpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp0492HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp0492HpCap;
                }
            }
            if (this.plugin.Config.Allow049HPScale && ev.Player.Role == RoleType.Scp049)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp049HpCap > hp * this.plugin.Config.Scp049HpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp049HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp049HpCap;
                }
            }
            if (this.plugin.Config.Allow096HPScale && ev.Player.Role == RoleType.Scp096)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp096HpCap > hp * this.plugin.Config.Scp096HpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp096HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp096HpCap;
                }
            }
            if (this.plugin.Config.Allow173HPScale && ev.Player.Role == RoleType.Scp173)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp096HpCap > hp * this.plugin.Config.Scp173HpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp173HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp173HpCap;
                }
            }
            if (this.plugin.Config.Allow106HPScale && ev.Player.Role == RoleType.Scp106)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp106HpCap > hp * this.plugin.Config.Scp106HpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp106HpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp106HpCap;
                }
            }
            if (this.plugin.Config.Allow939HPScale && ev.Player.Role == RoleType.Scp93953)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp939sHpCap > hp * this.plugin.Config.Scp939sHpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp939sHpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp939sHpCap;
                }
            }
            if (this.plugin.Config.Allow939HPScale && ev.Player.Role == RoleType.Scp93989)
            {
                int hp = 0;
                foreach (Player i in playerList)
                {
                    hp++;
                }
                if (this.plugin.Config.Scp939sHpCap > hp * this.plugin.Config.Scp939sHpScaleAdd)
                {
                    ev.Player.Health = hp * this.plugin.Config.Scp939sHpScaleAdd;
                }
                else
                {
                    ev.Player.Health = this.plugin.Config.Scp939sHpCap;
                }
            }
        }
    }
}
