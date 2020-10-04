using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Mosscobble
{
    public class ProMosscobbleAxe : ModProjectile
    {
        private int BackingTime;
        public override string Texture => "OdeMod/Items/Mosscobble/MosscobbleAxe";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mosscobble Axe");
            DisplayName.AddTranslation(GameCulture.Chinese, "苔石斧");
        }
        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 30;
            projectile.damage = 13;
            projectile.height = 30;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 100;
            projectile.knockBack = 8;
            projectile.penetrate = -1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
        }
        public override void AI()
        {
            projectile.rotation += 0.5f;
            if (projectile.rotation >= 6.282f) { projectile.rotation = 0; }
            if (projectile.timeLeft >= 50 && projectile.timeLeft < 97)
            {
                NPC tar = null;
                float disMAX = 500;
                foreach (NPC npc in Main.npc)
                {
                    if (npc.active && !npc.friendly && !npc.dontTakeDamage && Collision.CanHit(projectile.Center, 1, 1, npc.Center, 1, 1) &&
                        npc.type != NPCID.LunarTowerVortex && npc.type != NPCID.LunarTowerStardust && npc.type != NPCID.LunarTowerNebula &&
                        npc.type != NPCID.LunarTowerSolar && Vector2.Distance(npc.Center, projectile.Center) <= disMAX) { tar = npc; }
                }
                if (tar != null)
                {
                    Vector2 tVEC = Vector2.Normalize(tar.Center - projectile.Center) * 10;
                    float nFLOAT = 40f;
                    if (nFLOAT > 0) { nFLOAT--; }
                    projectile.velocity = (projectile.velocity * nFLOAT + tVEC) / (nFLOAT + 1);
                }
            }
            else if (projectile.timeLeft < 25)
            {
                Player player = Main.player[projectile.owner];
                Vector2 tVEC = Vector2.Normalize(player.Center - projectile.Center) * 10;
                projectile.velocity = tVEC;
                if (projectile.timeLeft <= 1 && Vector2.Distance(player.Center, projectile.Center) > player.width)
                {
                    projectile.timeLeft++;
                    projectile.velocity *= 2;
                }
                if (Vector2.Distance(player.Center, projectile.Center) <= player.width) { projectile.Kill(); }
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (BackingTime <= 2)
            {
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X;
                    BackingTime++;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y;
                    BackingTime++;
                }
            }
            else
            {
                projectile.tileCollide = false;
                if (projectile.timeLeft > 30) { projectile.timeLeft = 25; }
            }
            return false;
        }
    }
}