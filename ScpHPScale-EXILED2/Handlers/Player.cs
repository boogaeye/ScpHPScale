using Exiled.Events.EventArgs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScpHPScale_EXILED2.Handlers
{
    class Player
    {
        public List<Exiled.API.Features.Player> PlayersJoins = new List<Exiled.API.Features.Player>() { };
        public void Join(JoinedEventArgs ev)
        {
            PlayersJoins.Add(ev.Player);
        }
        public void Leave(LeftEventArgs ev)
        {
            PlayersJoins.Remove(ev.Player);
        }
        public void Spawn(SpawningEventArgs ev)
        {
            int delay = ScpHPScale.instance.Config.ScpHpDelay;
            Task.Delay(delay).ContinueWith(t => ApplyHPSpawn(ev));
        }
        public void OnRoleChange(ChangingRoleEventArgs ev)
        {
            int delay = ScpHPScale.instance.Config.ScpHpDelay;
            Task.Delay(delay).ContinueWith(t => ApplyHPRole(ev));
        }
        public void ApplyHPSpawn(SpawningEventArgs ev)
        {
            if (ev.RoleType == RoleType.Scp096 && ScpHPScale.instance.Config.Allow096HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp096HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp096HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp096HpCap;
                }
            }
            if (ev.RoleType == RoleType.Scp93989 || ev.RoleType == RoleType.Scp93953 && ScpHPScale.instance.Config.Allow939HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp939sHpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp939sHpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp939sHpCap;
                }
            }
            if (ev.RoleType == RoleType.Scp173 && ScpHPScale.instance.Config.Allow173HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp173HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp173HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp173HpCap;
                }
            }
            if (ev.RoleType == RoleType.Scp049 && ScpHPScale.instance.Config.Allow049HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp049HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp049HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp049HpCap;
                }
            }
            if (ev.RoleType == RoleType.Scp0492 && ScpHPScale.instance.Config.Allow0492HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp0492HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp0492HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp0492HpCap;
                }
            }
            if (ev.RoleType == RoleType.Scp106 && ScpHPScale.instance.Config.Allow106HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp106HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp106HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp106HpCap;
                }
            }
        }
        public void ApplyHPRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleType.Scp096 && ScpHPScale.instance.Config.Allow096HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp096HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp096HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp096HpCap;
                }
            }
            if (ev.NewRole == RoleType.Scp93989 || ev.NewRole == RoleType.Scp93953 && ScpHPScale.instance.Config.Allow096HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp939sHpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp939sHpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp939sHpCap;
                }
            }
            if (ev.NewRole == RoleType.Scp173 && ScpHPScale.instance.Config.Allow173HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp173HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp173HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp173HpCap;
                }
            }
            if (ev.NewRole == RoleType.Scp049 && ScpHPScale.instance.Config.Allow049HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp049HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp049HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp049HpCap;
                }
            }
            if (ev.NewRole == RoleType.Scp0492 && ScpHPScale.instance.Config.Allow0492HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp0492HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp0492HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp0492HpCap;
                }
            }
            if (ev.NewRole == RoleType.Scp106 && ScpHPScale.instance.Config.Allow106HPScale)
            {
                float count = PlayersJoins.Count;
                ev.Player.Health = ScpHPScale.instance.Config.Scp106HpScaleAdd * count;
                if (ev.Player.Health > ScpHPScale.instance.Config.Scp106HpCap)
                {
                    ev.Player.Health = ScpHPScale.instance.Config.Scp106HpCap;
                }
            }
        }
    }
}
