using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.Cemetery
{
    public class TileWhiteSoulStone : ModTile
    {
        public override void SetDefaults()
        {
            drop = ModContent.ItemType<Items.Cemetery.WhiteSoulStone>();
            dustType = MyDustId.White;
            soundType = 21;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("White Soul Stone");
            name.AddTranslation(Terraria.Localization.GameCulture.Chinese, "白魄石");
            AddMapEntry(new Color(183, 194, 194), name);

            TileObjectData.addTile(Type);
        }
    }
}