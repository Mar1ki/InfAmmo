using HarmonyLib;
using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfAmmo
{
    [HarmonyPatch(typeof(InventoryExtensions), nameof(InventoryExtensions.ServerSetAmmo))]
    internal class Patch
    {
        private static bool Prefix(Inventory inv, ItemType ammoType, int amount)
        {
            amount = 200;
            return true;
        }//
    }
}
