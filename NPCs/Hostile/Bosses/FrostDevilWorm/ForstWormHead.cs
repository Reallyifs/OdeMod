using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public class ForstWormHead : ModNPC
    {
        private bool spawned = false;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Worm");
            DisplayName.AddTranslation(GameCulture.Chinese, "寒霜蠕虫");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 20;
            npc.value = 10;
            npc.aiStyle = 6;
            npc.npcSlots = 5f;
            npc.netAlways = true;
            npc.damage = 15;
            npc.defense = 15;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            npc.behindTiles = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[20] = true;
            npc.buffImmune[24] = true;
            npc.SetElementDamage(5);
        }

        public override void AI()
        {
            if (!spawned)
            {
                Spawn(npc.whoAmI);
                spawned = true;
            }
        }

        private void Spawn(int startID)
        {
            npc.ai[3] = npc.whoAmI;
            npc.realLife = npc.whoAmI;
            int id1 = startID;
            for (int i = 0; i < 20; i++)
            {
                int type = i < 19 ? ModContent.NPCType<ForstWormBody>() : ModContent.NPCType<ForstWormTail>();
                int SubID = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, type, npc.whoAmI, 0f, 0f, 0f, 0f, 255);
                Main.npc[SubID].ai[3] = npc.whoAmI;
                Main.npc[SubID].realLife = npc.whoAmI;
                Main.npc[SubID].ai[1] = id1;
                Main.npc[id1].ai[0] = SubID;
                NetMessage.SendData(MessageID.SyncNPC, -1, -1, NetworkText.Empty, SubID, 0f, 0f, 0f, 0, 0, 0);
                id1 = SubID;
            }
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 7; i++)
            {
                int id = Dust.NewDust(npc.position, npc.width, npc.height, 197, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[id].noGravity = true;
            }
        }
    }
}