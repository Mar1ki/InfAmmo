using Exiled.API.Extensions;
using Exiled.Events.EventArgs.Player;
using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfAmmo
{
    public class EventHandler
    {
        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.ReloadingWeapon += OnReloading;
        }
        public void OnReloading(ReloadingWeaponEventArgs ev)
        {
            if (ev.Item.Type == ItemType.ParticleDisruptor) return;
            ev.Player.Inventory.ServerSetAmmo(ev.Firearm.AmmoType.GetItemType(), 0);
            ev.Player.AddAmmo(ev.Firearm.AmmoType, 100);
        }
        public void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.ReloadingWeapon -= OnReloading;
        }
    }
}
