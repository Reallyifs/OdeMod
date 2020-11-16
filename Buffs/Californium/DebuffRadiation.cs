using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Buffs.Californium
{
    public class DebuffRadiation : ModBuff
    {
        private bool[] vNPC, vPLAYER;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Radiation");
            DisplayName.AddTranslation(GameCulture.Chinese, "辐射");
            Description.SetDefault("Your life is going faster with time...");
            Description.AddTranslation(GameCulture.Chinese, "你的时间流逝得更快了……");

            longerExpertDebuff = true;
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = false;
            vNPC = new bool[Main.npc.Length];
            vPLAYER = new bool[Main.player.Length];
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            int damage = 0;
            if (Main.rand.Next(0, 5) < 2)
            {
                damage += 2;
                damage += (Main.rand.Next(0, 10) < 1) ? 4 : 0;
                damage += (Main.rand.Next(0, 20) < 1) ? 8 : 0;
            }
            if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
            npc.lifeRegen -= damage;
            foreach (NPC target in Main.npc)
            {
                if (Vector2.Distance(target.Center, npc.Center) <= 50 && target.active && !target.friendly && !vNPC[npc.whoAmI])
                {
                    vNPC[target.whoAmI] = true;
                    if (!target.HasBuff(ModContent.BuffType<DebuffRadiation>()))
                        target.AddBuff(Type, buffIndex / 4);
                }
            }
        }

        public override void Update(Player player, ref int buffIndex)
        {
            int damage = 0;
            if (Main.rand.Next(0, 5) < 2)
            {
                damage += 2;
                damage += (Main.rand.Next(0, 10) < 1) ? 4 : 0;
                damage += (Main.rand.Next(0, 20) < 1) ? 8 : 0;
            }
            if (player.lifeRegen > 0)
                player.lifeRegen = 0;
            player.lifeRegen -= damage;
            foreach (Player target in Main.player)
            {
                if (Vector2.Distance(target.Center, player.Center) <= 50 &&
                    target.active &&
                    target.team == player.team &&
                    !vPLAYER[player.whoAmI])
                {
                    vPLAYER[target.whoAmI] = true;
                    if (!target.HasBuff(ModContent.BuffType<DebuffRadiation>()))
                        target.AddBuff(Type, buffIndex / 8);
                }
            }
        }
    }
}