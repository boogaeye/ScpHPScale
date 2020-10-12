using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ScpHPScale_EXILED2
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Sets The delay to start up the health delay(This is here so that other plugins dont overlay the HP) this is in milliseconds (Tip: its probably best to keep the default as 1000 if your HP still doesnt change add 1000 and repeat...)")]
        public int ScpHpDelay { get; set; } = 1000;
        [Description("Sets if SCP096 gets effected by the HP player scale")]
        public bool Allow096HPScale { get; set; } = true;
        [Description("Sets The max HP to cap SCP096 at")]
        public float Scp096HpCap { get; set; } = 500;
        [Description("Sets The amount of HP to add to SCP096 per player")]
        public float Scp096HpScaleAdd { get; set; } = 100;
        [Description("Sets if SCP173 gets effected by the HP player scale")]
        public bool Allow173HPScale { get; set; } = false;
        [Description("Sets The max HP to cap SCP173 at")]
        public float Scp173HpCap { get; set; } = 3200;
        [Description("Sets The amount of HP to add to SCP173 per player")]
        public float Scp173HpScaleAdd { get; set; } = 500;
        [Description("Sets if SCP106 gets effected by the HP player scale")]
        public bool Allow106HPScale { get; set; } = true;
        [Description("Sets The max HP to cap SCP106 at")]
        public float Scp106HpCap { get; set; } = 650;
        [Description("Sets The amount of HP to add to SCP106 per player")]
        public float Scp106HpScaleAdd { get; set; } = 100;
        [Description("Sets if SCP049 gets effected by the HP player scale")]
        public bool Allow049HPScale { get; set; } = true;
        [Description("Sets The max HP to cap SCP049 at")]
        public float Scp049HpCap { get; set; } = 1900;
        [Description("Sets The amount of HP to add to SCP049 per player")]
        public float Scp049HpScaleAdd { get; set; } = 450;
        [Description("Sets if SCP049-2 gets effected by the HP player scale")]
        public bool Allow0492HPScale { get; set; } = false;
        [Description("Sets The max HP to cap SCP049-2 at")]
        public float Scp0492HpCap { get; set; } = 1000;
        [Description("Sets The amount of HP to add to SCP049-2 per player")]
        public float Scp0492HpScaleAdd { get; set; } = 250;
        [Description("Sets if SCP939's gets effected by the HP player scale")]
        public bool Allow939HPScale { get; set; } = true;
        [Description("Sets The max HP to cap SCP939's at")]
        public float Scp939sHpCap { get; set; } = 2200;
        [Description("Sets The amount of HP to add to SCP939's per player")]
        public float Scp939sHpScaleAdd { get; set; } = 450;
        [Description("Sets if a hint message is sent when HP is altered")]
        public bool AllowHpAlterHintMessage { get; set; } = true;
        [Description("Sets the hint message this can be used to tell people about their health")]
        public string HpAlterHintMessage { get; set; } = "Your HP has been Changed to make the game fair";
        public int HpAlterHintMessageDuration { get; set; } = 5;
    }
}
