using OdeMod.Buffs.Californium;
using OdeMod.Items.Californium;
using System;
using Terraria;
using Terraria.ModLoader;

namespace OdeMod.Projectiles
{
    public class OGlobalProjectile : GlobalProjectile
    {
        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (player.HeldItem<GammaDisembower>() || player.HeldItem<Plaguebatter>())
                target.AddBuff(ModContent.BuffType<DebuffRadiation>(), Math.Min(damage / 4, 600));
        }


        public override void OnHitPvp(Projectile projectile, Player target, int damage, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (player.HeldItem<GammaDisembower>() || player.HeldItem<Plaguebatter>())
                target.AddBuff(ModContent.BuffType<DebuffRadiation>(), Math.Min(damage / 8, 600));
        }
    }
}