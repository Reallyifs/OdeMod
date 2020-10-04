using Microsoft.Xna.Framework;
using OdeMod.Items.Brightiron;
using OdeMod.Items.Californium;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.NPCs
{
    public class OGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            int type = npc.type;
            Player player = Main.player[npc.target];
            if (type == NPCID.EaterofWorldsHead || type == NPCID.BrainofCthulhu)
            {
                if (!OWorld.SpawnBrightironOreAlready)
                {
                    OLanguage.GetForNewText("生成熙铁矿", Color.LightGray, true);
                    OWorld.SpawnBrightironOre();
                }
            }
            if (NPC.downedBoss2)
            {
                if (player.ZoneCorrupt || player.ZoneCrimson)
                {
                    if (Main.rand.Next(1, 3) <= 1)
                        Item.NewItem(npc.getRect(), ModContent.ItemType<SpiritPieces>(), Main.rand.Next(1, 4));
                }
            }
            if (NPC.downedMoonlord)
            {
                if (type == NPCID.PirateShip || type == NPCID.Pirate || (type >= 212 && type <= 216))
                {
                    if (Main.rand.Next(1, 3) <= 1)
                        Item.NewItem(npc.getRect(), ModContent.ItemType<CaliforniumBar>(), Main.rand.Next(2, 5));
                }
            }
        }
    }
}