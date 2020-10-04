using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
namespace OdeMod.Projectiles.Frosted
{
    public class ProFrostedSickle : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frosted Sickle");
            DisplayName.AddTranslation(GameCulture.Chinese, "凝霜镰刀");
        }
        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 24;
            projectile.damage = 83;
            projectile.height = 24;
            projectile.aiStyle = -1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.timeLeft = 600;
            projectile.knockBack = 4f;
            projectile.penetrate = 1;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.SetElementDamage(ElementDamageType.ForstDamage);
        }
        public override void AI()
        {
            projectile.rotation += 0.5f;
            projectile.velocity *= 0.9f;
            Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, MyDustId.BlueMagic, projectile.velocity.X / 3,
                projectile.velocity.Y / 3, Main.rand.Next(100, 200), Color.Blue, Main.rand.NextFloat(0.8f, 1.2f));
            dust.noGravity = true;
            if (projectile.rotation >= 6.282f) { projectile.rotation = 0; }
            if (projectile.timeLeft >= 340 && projectile.timeLeft <= 400)
            {
                projectile.rotation += 0.2f;
                projectile.velocity *= 0;
            }
            else if (projectile.timeLeft == 339)
            {
                NPC tar = null;
                foreach (NPC npc in Main.npc)
                {
                    if (npc.active && !npc.friendly && !npc.dontTakeDamageFromHostiles &&
                        Collision.CanHit(projectile.Center, projectile.width, projectile.height, npc.Center, npc.width, npc.height)) { tar = npc; }
                }
                Vector2 tVEC = Vector2.Normalize((tar != null ? tar.Center : Main.MouseWorld) - projectile.Center) * 30;
                projectile.velocity = tVEC;
            }
        }
    }
}