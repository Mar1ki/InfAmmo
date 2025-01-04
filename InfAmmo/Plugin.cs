using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfAmmo
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "Mariki";
        public override string Name => "InfAmmo";

        public static EventHandler handler;
        public override void OnEnabled()
        {
            handler = new EventHandler();
            handler.RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            handler = new EventHandler();
            handler.UnRegisterEvents();
            base.OnDisabled();
        }
    }
}
