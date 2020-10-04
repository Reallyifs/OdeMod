using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarlitRainbowCollection;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    [AutoloadBossHead]
    public partial class FrostDevilWormHead : ModNPC
    {
        int timer = 0;
        int counter = 0;
        int state = 0;
        int[] states = new int[] { 0, 1, 2, 3, 4, 0, 2, 0, 4, 3, 2, 1, 4, 0 };
        NPC[] tails = new NPC[44];
        public Player tPlayer { get { return Main.player[npc.target]; } }
        public virtual int proDamage
        {
            get
            {
                return (int)(npc.damage / (Main.expertMode ? 2.5f : 1f));
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Devil Worm");
            DisplayName.AddTranslation(GameCulture.Chinese, "寒霜魔虫");
        }
        public override void SetDefaults()
        {
            npc.width = 36;
            npc.height = 44;
            npc.value = 2000;
            npc.aiStyle = 6;
            npc.npcSlots = 5f;
            npc.netAlways = true;
            npc.damage = 40;
            npc.defense = 16;
            npc.lifeMax = 3000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.behindTiles = true;
            npc.buffImmune[20] = true;
            npc.buffImmune[24] = true;
            npc.SetElementDamage(5);
            npc.boss = true;
        }
        public override bool PreAI()
        {
            if (timer == 0)
            {
                SpawnTail(npc.whoAmI);
            }
            return base.PreAI();
        }
        public override void AI()
        {
            timer++;
            if (state == 0 && npc.life < npc.lifeMax / 2)
            {
                states[(counter + 1) % states.Length] = 5;
                npc.Approach(tPlayer.Center, 0.5f);
                npc.velocity *= 2;
                Explode.DustExplodeEasy(npc.Center, 100, 30, 197, 1, 100, Color.White, 3f);
                state++;
            }
            switch (states[counter])
            {
                case 0: State0(); break;
                case 1: State1(); break;
                case 2: State2(); break;
                case 3: State3(); break;
                case 4: State4(); break;
                case 5: State5(); break;
            }
            npc.rotation = npc.velocity.ToRotation() + 1.57f;
        }

        public override bool CheckActive()
        {
            return false;
        }

        public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
        {
            SetTailImmune(projectile.owner, 4);
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 14; i++)
            {
                int id = Dust.NewDust(npc.position, npc.width, npc.height, 197, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[id].noGravity = true;
            }
        }

        public void SetTailImmune(int target, int timer)
        {
            npc.immune[target] = Math.Max(npc.immune[target], timer);
            for (int i = 0; i < 44; i++)
            {
                tails[i].immune[target] = Math.Max(npc.immune[target], timer);
            }
        }

        private void SpawnTail(int startID)
        {
            npc.ai[3] = npc.whoAmI;
            npc.realLife = npc.whoAmI;
            int id1 = startID;
            for (int i = 0; i < 44; i++)
            {
                int type = 0;
                if (i < 43)
                {
                    type = mod.NPCType("FrostDevilWormBody");
                }
                else
                {
                    type = mod.NPCType("FrostDevilWormTail");
                }
                int id2 = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, type, npc.whoAmI, 0f, 0f, 0f, 0f, 255);
                Main.npc[id2].ai[3] = npc.whoAmI;
                Main.npc[id2].realLife = npc.whoAmI;
                Main.npc[id2].ai[1] = id1;
                Main.npc[id1].ai[0] = id2;
                NetMessage.SendData(23, -1, -1, NetworkText.Empty, id2, 0f, 0f, 0f, 0, 0, 0);
                tails[i] = Main.npc[id2];
                id1 = id2;
            }
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            Vector2 drawPos = npc.Center - Main.screenPosition + new Vector2(0f, npc.gfxOffY);
            var se = SpriteEffects.None;
            Vector2 origin = new Vector2(npc.width, npc.height) / 2;
            spriteBatch.Draw(Main.npcTexture[npc.type], drawPos, npc.frame, drawColor, npc.rotation, origin, npc.scale, se, 0);
            Color c = drawColor == Color.Black ? drawColor : MixColor(drawColor, 1, Color.White, 1);
            spriteBatch.Draw(ModContent.GetTexture(Texture + "_Glow"), drawPos, npc.frame, c, npc.rotation, origin, npc.scale, se, 0);
            return false;
        }

        public static Color MixColor(Color c1, float s1, Color c2, float s2)
        {
            Vector4 v = (c1.ToVector4() * s1 + c2.ToVector4() * s2) / (s1 + s2);
            return new Color(v);
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.damage = 64;
        }
    }
}
