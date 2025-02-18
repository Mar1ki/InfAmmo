﻿using Exiled.API.Extensions;
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
            new HarmonyLib.Harmony("mmm").PatchAll();
            Exiled.Events.Handlers.Player.Spawned += OnSpawned;
            Exiled.Events.Handlers.Player.DroppingAmmo += OnDroppingAmmo;
        }
        public void OnDroppingAmmo(DroppingAmmoEventArgs ev)
        {
            ev.IsAllowed = false;
        }
        public void OnSpawned(SpawnedEventArgs ev)
        {
            ev.Player.Inventory.ServerSetAmmo(ItemType.Ammo44cal, 200);
            ev.Player.Inventory.ServerSetAmmo(ItemType.Ammo12gauge, 200);
            ev.Player.Inventory.ServerSetAmmo(ItemType.Ammo556x45, 200);
            ev.Player.Inventory.ServerSetAmmo(ItemType.Ammo762x39, 200);
            ev.Player.Inventory.ServerSetAmmo(ItemType.Ammo9x19, 200);
        }

        public void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawned;
            Exiled.Events.Handlers.Player.DroppingAmmo -= OnDroppingAmmo;
        }
    }
}
