using OdeMod.Tiles.Brightiron;
using OdeMod.Tiles.Mosscobble;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace OdeMod
{
    public class OWorld : ModWorld
    {
        public static bool SpawnBrightironOreAlready;

        public override void Initialize()
        {
            SpawnBrightironOreAlready = false;
        }

        public override TagCompound Save()
        {
            List<string> array = new List<string>();
            if (SpawnBrightironOreAlready)
                array.Add("SpawnBrightironOreAlready");
            return new TagCompound()
            {
                ["OdeSave"] = array
            };
        }

        public override void Load(TagCompound tag)
        {
            IList<string> array = tag.GetList<string>("OdeSave");
            SpawnBrightironOreAlready = array.Contains("SpawnBrightironOreAlready");
        }

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int Shinies = tasks.FindIndex((GenPass value) => value.Name.Contains("Shinies"));
            if (Shinies != -1)
                tasks.Insert(Shinies + 1, new PassLegacy("OdeMod:SpawnMosscobble", SpawnMosscobble));
        }

        private void SpawnMosscobble(GenerationProgress progress)
        {
            progress.Message = OLanguage.Get("生成苔石", true);
            int fINT = 0;
            int sNumber = 0;
            for (int x = 0; x < Main.maxTilesX - 50; x++)
            {
                for (int y = 0; y < Main.maxTilesY - 250; y++)
                {
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.type == TileID.Stone)
                    {
                        if (sNumber <= 0)
                            fINT = x;
                        sNumber++;
                    }
                    if (tile.type != TileID.Stone)
                    {
                        if (sNumber >= 10)
                        {
                            int lINT = y;
                            int maxTile = Main.rand.NextBool() ? sNumber / 3 : 0;
                            WorldGen.TileRunner(fINT, lINT, maxTile, Main.rand.Next(1, 4), ModContent.TileType<TileMosscobble>());
                        }
                        fINT = sNumber = 0;
                    }
                }
            }
            for (int y = 0; y < Main.maxTilesY - 250; y++)
            {
                for (int x = 0; x < Main.maxTilesX - 50; x++)
                {
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.type == TileID.Stone)
                    {
                        if (sNumber <= 0)
                            fINT = x;
                        sNumber++;
                    }
                    if (tile.type != TileID.Stone)
                    {
                        if (sNumber >= 10)
                        {
                            int lINT = y;
                            int maxTile = Main.rand.NextBool() ? sNumber / 3 : 0;
                            WorldGen.TileRunner(fINT, lINT, maxTile, Main.rand.Next(1, 4), ModContent.TileType<TileMosscobble>());
                        }
                        fINT = sNumber = 0;
                    }
                }
            }
        }

        internal static void SpawnBrightironOre()
        {
            if (!SpawnBrightironOreAlready)
            {
                int maxTile = (int)(Main.maxTilesX * Main.maxTilesY * 9E-04);
                for (int i = 0; i < maxTile; i++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.rockLayerHigh, Main.maxTilesY);
                    WorldGen.TileRunner(x, y, Main.rand.Next(1, 5), Main.rand.Next(2, 5), ModContent.TileType<TileBrightironOre>());
                }
                SpawnBrightironOreAlready = true;
            }
        }
    }
}