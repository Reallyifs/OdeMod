using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TileAncientPlantBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("AncientPlant");
            dustType = MyDustId.BlueDrakParticle;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Ancient Plant");
            name.AddTranslation(GameCulture.Chinese, "远古植物");
            AddMapEntry(new Color(255, 247, 191), name);

            TileObjectData.addTile(Type);
        }
    }
}