using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod.Buffs.Californium
{
    public class BuffSpeedingTramcar : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Speeding Tramcar");
            DisplayName.AddTranslation(GameCulture.Chinese, "超速矿车");
            Description.SetDefault("How-- fast----");
            Description.AddTranslation(GameCulture.Chinese, "好——快啊————");

            canBeCleared = true;
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            Main.buffTexture[Type] = Main.buffTexture[BuffID.MinecartLeftMech];
            Main.buffNoTimeDisplay[Type] = true;
        }
    }
}