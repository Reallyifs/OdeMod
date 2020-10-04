using Terraria.ModLoader;

namespace OdeMod
{
    public class OdeMod : Mod
    {
        /// <summary>
        /// 此 Mod 的实例
        /// </summary>
        internal static OdeMod Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// 是否处于开发者模式，发布正式版时记得设成 <see langword="false"/>
        /// </summary>
        internal static bool Developer
        {
            get => true;
        }

        public OdeMod()
        {
            Instance = this;
        }

        public override void Load()
        {
            OLanguage.Load();
        }

        public override void Unload()
        {
            OLanguage.Unload();
        }
    }
}