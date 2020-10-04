using Microsoft.Xna.Framework;
using OdeMod.Items.SoulRift;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileLivingStarBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<LivingStar>();
            dustType = MyDustId.GreenBubble;
            soundType = SoundID.Tink;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Living Star");
            name.AddTranslation(GameCulture.Chinese, "生命之心");
            AddMapEntry(new Color(214, 240, 118), name);

            TileObjectData.addTile(Type);
        }
    }
}