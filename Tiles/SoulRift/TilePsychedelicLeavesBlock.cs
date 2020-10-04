using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OdeMod.Tiles.SoulRift
{
    public class TilePsychedelicLeavesBlock : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("PsychedelicLeaves");
            dustType = MyDustId.PurpleLight;
            soundType = SoundID.Dig;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Psychedelic Leaves");
            name.AddTranslation(GameCulture.Chinese, "迷幻树叶");
            AddMapEntry(new Color(255, 247, 191), name);

            TileObjectData.addAlternate(Type);
        }
    }
}