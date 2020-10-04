using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public class ForstWormBody : ModNPC
    {
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
            npc.dontCountMe = true;
            npc.buffImmune[20] = true;
            npc.buffImmune[24] = true;
            npc.SetElementDamage(5);
        }
        public override void AI()
        {
            if (!Main.npc[(int)npc.ai[1]].active)
            {
                npc.life = 0;
                npc.HitEffect(0, 10);
                npc.active = false;
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