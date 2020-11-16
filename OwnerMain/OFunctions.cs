using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod
{
    public static class OFunctions
    {
        public static bool IsAnyTower(this NPC npc)
        {
            return npc.type == NPCID.LunarTowerVortex
                || npc.type == NPCID.LunarTowerStardust
                || npc.type == NPCID.LunarTowerNebula
                || npc.type == NPCID.LunarTowerSolar;
        }

        public static void ToNewText(this string text, Color textColor, bool force = false)
        {
            if (Main.netMode == NetmodeID.SinglePlayer)
                Main.NewText(text, textColor, force);
        }

        public static void ToNewText(this string text, byte R = 255, byte G = 255, byte B = 255, bool force = false)
        {
            if (Main.netMode == NetmodeID.SinglePlayer)
                Main.NewText(text, R, G, B, force);
        }

        public static OPlayer OPlayer(this Player player) => player.GetModPlayer<OPlayer>();

        public static bool ItemType<T>(this int type) where T : ModItem => type == ModContent.ItemType<T>();

        public static bool HeldItem<T>(this Player player) where T : ModItem => player.HeldItem.type == ModContent.ItemType<T>();

        public static bool Armor<Head, Body, Legs>(this Player player) where Head : ModItem where Body : ModItem where Legs : ModItem
        {
            return Armor(player, ModContent.ItemType<Head>(), ModContent.ItemType<Body>(), ModContent.ItemType<Legs>());
        }

        public static bool Armor(this Player player, int head = 0, int body = 0, int legs = 0)
        {
            bool result = true;
            if (head != 0)
                result &= player.armor[0].type == head;
            if (body != 0)
                result &= player.armor[1].type == body;
            if (legs != 0)
                result &= player.armor[2].type == legs;
            return result;
        }

        /// <summary>
        /// 返回一个Length为 <paramref name="Height"/>，所有值为 16 的数组
        /// </summary>
        public static int[] SetCoordinateHeights(int Height)
        {
            int[] i = new int[Height];
            for (int i2 = 0; i2 < i.Length; i2++)
                i[i2] = 16;
            return i;
        }
    }
}