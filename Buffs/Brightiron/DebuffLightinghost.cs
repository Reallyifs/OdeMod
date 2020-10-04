using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Buffs.Brightiron
{
    public class DebuffLightinghost : ModBuff
    {
        private bool Lightinghostes = false;
        private float Lightstrong = 0.3f;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lightinghost");
            DisplayName.AddTranslation(GameCulture.Chinese, "光魂");
            Description.SetDefault("You are surrounded by a group of lightinghost scattered with light");
            Description.AddTranslation(GameCulture.Chinese, "你被一群散着光的灵魂围住了");

            longerExpertDebuff = true;
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            Lighting.AddLight(player.Center, Lightstrong, Lightstrong, Lightstrong);
            player.statDefense -= (int)((Lightinghostes ? 15 : 10) * (1 + (Lightstrong * 1.2f)));
            if (Main.rand.Next(1, 3) <= 1)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Dust.NewDustDirect(player.Center, player.width, player.height, MyDustId.YellowGoldenFire, player.velocity.X / 3,
                        player.velocity.Y / 3, Main.rand.Next(100, 200), Color.LightYellow, Main.rand.NextFloat(0.8f, 1.2f));
                }
            }
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            Lighting.AddLight(npc.Center, Lightstrong, Lightstrong, Lightstrong);
            npc.defense -= (int)((Lightinghostes ? 30 : 15) * (1 + Lightstrong));
            if (Main.rand.Next(1, 3) <= 1)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Dust.NewDustDirect(npc.Center, npc.width, npc.height, MyDustId.YellowGoldenFire, npc.velocity.X / 3, npc.velocity.Y / 3,
                        Main.rand.Next(100, 200), Color.LightYellow, Main.rand.NextFloat(0.8f, 1.2f));
                }
            }
        }

        public override bool ReApply(NPC npc, int time, int buffIndex)
        {
            Lightstrong += 0.1f;
            Lightinghostes = true;
            return true;
        }
    }
}