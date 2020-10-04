using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public class FrostProbe : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Probe");
            DisplayName.AddTranslation(GameCulture.Chinese, "寒霜探针");
        }

        public override void SetDefaults()
        {
            npc.width = 26;
            npc.height = 32;
            npc.value = 10;
            npc.aiStyle = 14;
            npc.damage = 25;
            npc.defense = 5;
            npc.lifeMax = 15;
            npc.HitSound = SoundID.NPCHit5;
            npc.DeathSound = SoundID.NPCDeath7;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.knockBackResist = 0.5f;
            npc.SetElementDamage(5);
        }

        public override void AI()
        {
            npc.TargetClosest(true);
            if (npc.velocity.X > 0)
            {
                npc.spriteDirection = -1;
            }
            if (npc.velocity.X < 0)
            {
                npc.spriteDirection = 1;
            }
            if (Vector2.Distance(npc.Center, Main.player[npc.target].Center) > 100)
            {
                npc.ai[0]++;
                if (npc.ai[0] > 0f)
                {
                    npc.velocity.Y += 0.02f;
                }
                else
                {
                    npc.velocity.Y -= 0.02f;
                }
                if (npc.ai[0] < -100f || npc.ai[0] > 100f)
                {
                    npc.velocity.X += 0.02f;
                }
                else
                {
                    npc.velocity.X -= 0.02f;
                }
                if (npc.ai[0] > 200f)
                {
                    npc.ai[0] = -200f;
                }
            }
            if (npc.collideX)
            {
                npc.netUpdate = true;
                npc.velocity.X = npc.oldVelocity.X * -0.7f;
                if (npc.direction == -1 && npc.velocity.X > 0f && npc.velocity.X < 2f)
                {
                    npc.velocity.X = 2f;
                }
                if (npc.direction == 1 && npc.velocity.X < 0f && npc.velocity.X > -2f)
                {
                    npc.velocity.X = -2f;
                }
            }
            if (npc.collideY)
            {
                npc.netUpdate = true;
                npc.velocity.Y = npc.oldVelocity.Y * -0.7f;
                if (npc.velocity.Y > 0f && npc.velocity.Y < 1.5)
                {
                    npc.velocity.Y = 2f;
                }
                if (npc.velocity.Y < 0f && npc.velocity.Y > -1.5)
                {
                    npc.velocity.Y = -2f;
                }
            }
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 8; i++)
            {
                int id = Dust.NewDust(npc.position, npc.width, npc.height, 197, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[id].noGravity = true;
            }
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.damage = 42;
        }
    }
}
