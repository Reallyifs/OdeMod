using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.Items
{
    public class OGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            SetMaxStack(item);
        }

        public static void SetMaxStack(Item item)
        {
            List<int> i999 = new List<int>()
            {
                ItemID.Torch,
                ItemID.IceTorch,
                ItemID.RedTorch,
                ItemID.BlueTorch,
                ItemID.BoneTorch,
                ItemID.PinkTorch,
                ItemID.TikiTorch,
                ItemID.DemonTorch,
                ItemID.GreenTorch,
                ItemID.IchorTorch,
                ItemID.WhiteTorch,
                ItemID.CursedTorch,
                ItemID.OrangeTorch,
                ItemID.PurpleTorch,
                ItemID.YellowTorch,
                ItemID.RainbowTorch,
                ItemID.UltrabrightTorch
            };
            if (i999.Contains(item.type))
                item.maxStack = 999;
        }
    }
}