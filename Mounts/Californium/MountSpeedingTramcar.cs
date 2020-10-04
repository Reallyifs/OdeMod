using Microsoft.Xna.Framework;
using OdeMod.Buffs.Californium;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OdeMod.Mounts.Californium
{
    public class MountSpeedingTramcar : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.buff = ModContent.BuffType<BuffSpeedingTramcar>();
            mountData.extraBuff = mountData.buff;

            mountData.xOffset = -1;
            mountData.yOffset = 11;
            mountData.playerHeadOffset = 14;
            mountData.textureWidth = 46;
            mountData.textureHeight = 26;

            mountData.Minecart = true;
            mountData.MinecartDust = DelegateMethods.Minecart.SparksMech;

            mountData.runSpeed = 20f;
            mountData.dashSpeed = 20f;
            mountData.jumpHeight = 10;
            mountData.jumpSpeed = 5.15f;
            mountData.heightBoost = 12;

            mountData.spawnDust = MyDustId.DarkGrey;
            mountData.spawnDustNoGravity = true;
            mountData.fallDamage = 1f;
            mountData.acceleration = 0.2f;
            mountData.blockExtraJumps = true;

            mountData.bodyFrame = 1;
            mountData.totalFrames = 1;
            mountData.idleFrameLoop = false;

            if (Main.netMode != NetmodeID.Server)
            {
                mountData.backTexture = null;
                mountData.backTextureExtra = null;

                mountData.frontTexture = mod.GetTexture("Mounts/Californium/MountSpeedingTramcar");
                mountData.textureWidth = mountData.frontTexture.Width;
                mountData.textureHeight = mountData.frontTexture.Height;

                mountData.frontTextureGlow = mod.GetTexture("Mounts/Californium/MountSpeedingTramcar");
                mountData.frontTextureExtra = null;
            }

            int[] i = new int[mountData.totalFrames];
            for (int i2 = 0; i2 < i.Length; i2++)
                i[i2] = 9;
            mountData.playerYOffsets = i;
        }

        public override void UpdateEffects(Player player)
        {
            player.maxRunSpeed += 50;
            player.statDefense += (int)(2f * (1f + (Math.Abs(player.velocity.X) / mountData.runSpeed * 4f)));
            foreach (NPC npc in Main.npc)
            {
                if (npc.active && !npc.friendly && Collision.CanHit(player.Center, 1, 1, npc.Center, 1, 1) &&
                    Vector2.Distance(player.Center, npc.Center) <= 100)
                    npc.AddBuff(ModContent.BuffType<DebuffRadiation>(), 30);
            }
        }

        public override void JumpHeight(Player mountedPlayer, ref int jumpHeight, float xVelocity)
        {
            if (xVelocity > 1)
                jumpHeight += 1;
        }
    }
}