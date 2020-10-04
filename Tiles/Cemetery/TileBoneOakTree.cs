using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace OdeMod.Tiles.Cemetery
{
    public class TileBoneOakTree : ModTree
    {
        private Mod mod => OdeMod.Instance;

        public override int CreateDust()
        {
            return MyDustId.BrownMaterial;
        }

        public override int DropWood()
        {
            return ModContent.ItemType<BoneOakWood>();
        }

        public override int GrowthFXGore()
        {
            return 914;
        }

        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/MapleGrove/TileBoneOakTree");
        }

        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft,
            ref int yOffset)
        {
            return mod.GetTexture("Tiles/MapleGrove/TileBoneOakTree_Tops");
        }

        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/MapleGrove/TileBoneOakTree_Branches");
        }
    }
}