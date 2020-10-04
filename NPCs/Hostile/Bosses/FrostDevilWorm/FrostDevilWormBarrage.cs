using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ModLoader;
namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public partial class FrostDevilWormHead : ModNPC
    {
        public void Barrage0(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Vector2 pos = Geometry.GetRandomPosInCircle(npc.Center, 70);
                Vector2 v = Geometry.GetFromToUnit(npc.Center, tPlayer.Center) * 8 + Geometry.GetRandomUnit();
                npc.SetBarrageFriendy(Projectile.NewProjectile(pos, v, mod.ProjectileType("IceCone"), (int)(proDamage * 0.5f), 2));
            }
        }
    }
}