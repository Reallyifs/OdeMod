using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OdeMod
{
    static class OLanguage
    {
        private static List<(string, string, string[])> Texts;
        private static Dictionary<string, string[]> TextValues;

        public static void Load()
        {
            Texts = new List<(string, string, string[])>();
            TextValues = new Dictionary<string, string[]>();

            Create();
            ArmorSet();

            End();
            Texts = null;
        }

        public static void Unload()
        {
            TextValues = null;
        }

        public static void GetForNewText(string internalCode, Color textColor, bool chineseCode = false)
        {
            Get(internalCode, chineseCode).ToNewText(textColor);
        }

        public static string Get(string internalCode, bool chineseCode = false)
        {
            if (!string.IsNullOrWhiteSpace(internalCode))
            {
                if (!chineseCode)
                    return Language.GetTextValue($"Mods.OdeMod.{internalCode}");
                else if (TextValues.ContainsKey(internalCode))
                {
                    int index = GameCulture.Chinese.IsActive ? 1 : 0;
                    return TextValues[internalCode][index];
                }
            }
            return string.Empty;
        }

        private static void End()
        {
            Texts.ForEach(delegate ((string, string, string[]) All)
            {
                ModTranslation translation = OdeMod.Instance.CreateTranslation(All.Item1);
                translation.SetDefault(All.Item3[0]);
                translation.AddTranslation(GameCulture.Chinese, All.Item3[1]);
                OdeMod.Instance.AddTranslation(translation);

                TextValues.Add(All.Item2, All.Item3);
            });
        }

        private static void ArmorSet()
        {
            Texts.Add(("ArmorSet.Mosscobble", "苔石套装描述", new string[]
            {
                "\"Rock punch\"!\n" +
                "When landing from the air greater than or equal to 7 blocks, two stone cones will be drawn to both sides, causing damage and knocking back the enemy",
                "“岩石重拳！”\n" +
                "从大于等于7格的空中落地时会向两边引出两个石锥，造成伤害并击退敌人"
            }));
            Texts.Add(("ArmorSet.Blightiron", "熙铁套装描述", new string[]
            {
                "Blightiron series weapons reduce the defense when attacking the enemy, increase the player's crit",
                "熙铁系列武器攻击敌人时减少的防御增加，增加玩家暴击率"
            }));
            Texts.Add(("ArmorSet.Lightmushroom", "光明蘑菇套装描述", new string[]
            {
                "The player's body glows, and any consumables used will explode a spore around him",
                "玩家身体发光，使用任何消耗品都会炸出一团孢子围绕在身边"
            }));
        }

        private static void Create()
        {
            Texts.Add(("Create.Mosscobble", "生成苔石", new string[]
            {
                "Crafting Mosscobble...",
                "生成苔石中……"
            }));
            Texts.Add(("Create.Blightiron", "生成熙铁矿", new string[]
            {
                "Bright light is shining in the stone...",
                "明亮的光芒在岩石间闪烁……"
            }));
        }
    }
}