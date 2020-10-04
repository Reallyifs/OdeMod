using Microsoft.Xna.Framework;
using OdeMod.Dusts;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Buffs
{
    public class DebuffNaturalPower : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Natural Power");
            DisplayName.AddTranslation(GameCulture.Chinese, "自然力量");
            Description.SetDefault("Element interference");
            Description.AddTranslation(GameCulture.Chinese, "元素干扰");

            longerExpertDebuff = true;
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            Lighting.AddLight(npc.Center, 1f, 1f, 1f);
            if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
            npc.lifeRegen -= 20;
            Dust.NewDustDirect(npc.position, 14, 54, ModContent.DustType<DustLeave>(), 0, -2f, 0, Color.White, 1f);
            Dust.NewDustDirect(npc.Center + new Vector2(Main.rand.Next(-20, 20), Main.rand.Next(-20, 20)), 0, 0, MyDustId.RedTorch, 0, 0);
            Dust.NewDustDirect(npc.Center, 10, 10, ModContent.DustType<DustWater>(), Main.rand.NextFloat(-1.5f, 1.5f), 2f, 0, Color.White, 2f);
        }
    }
}