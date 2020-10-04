using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileMossSkinBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("MossSkin");
            dustType = MyDustId.GreenBubble1;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Moss Skin");
            name.AddTranslation(GameCulture.Chinese, "苔藓皮");
            AddMapEntry(new Color(72, 187, 93), name);

            TileObjectData.addTile(Type);
        }
    }
}