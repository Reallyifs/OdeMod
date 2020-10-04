using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public class FrostDevilWormBody : ModNPC
    {
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
            npc.npcSlots = 2f;
            npc.netAlways = true;
            npc.damage = 20;
            npc.defense = 20;
            npc.lifeMax = 3000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0f;
            npc.boss = true;
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
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            return false;
        }
        public override bool CheckActive()
        {
            return false;
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 14; i++)
            {
                int id = Dust.NewDust(npc.position, npc.width, npc.height, 197, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[id].noGravity = true;
            }
        }
        public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
        {
            var head = (FrostDevilWormHead)Main.npc[npc.realLife].modNPC;
            head.SetTailImmune(projectile.owner, 5);
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            Vector2 drawPos = npc.Center - Main.screenPosition + new Vector2(0f, npc.gfxOffY);
            var se = SpriteEffects.None;
            Vector2 origin = new Vector2(npc.width, npc.height) / 2;
            spriteBatch.Draw(Main.npcTexture[npc.type], drawPos, npc.frame, drawColor, npc.rotation, origin, npc.scale, se, 0);
            Color c = drawColor == Color.Black ? drawColor : FrostDevilWormHead.MixColor(drawColor, 1, Color.White, 1);
            spriteBatch.Draw(ModContent.GetTexture(Texture + "_Glow"), drawPos, npc.frame, c, npc.rotation, origin, npc.scale, se, 0);
            return false;
        }
    }
}