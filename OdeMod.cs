using OdeMod.Events;
using OdeMod.Items;
using Terraria.ModLoader;

namespace OdeMod
{
    public class OdeMod : Mod
    {
        /// <summary>
        /// �� Mod ��ʵ��
        /// </summary>
        internal static OdeMod Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// �Ƿ��ڿ�����ģʽ��������ʽ��ʱ�ǵ���� <see langword="false"/>
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
            EclipseOfChaos.Load();
        }

        public override void Unload()
        {
            OLanguage.Unload();
            EclipseOfChaos.Unload();
        }

        public override void AddRecipeGroups() => ORecipes.AddRecipeGroups();
        public override void AddRecipes() => ORecipes.AddRecipes();
    }
}