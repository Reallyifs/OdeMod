using Terraria.ModLoader;

namespace OdeMod
{
    public class OPlayer : ModPlayer
    {
        public bool Wan;
        public bool BrightironArmorSet;
        public bool MosscobbleArmorSet;
        public bool LightmushroomArmorSet;

        public override void Initialize()
        {
            Wan = false;
            BrightironArmorSet = false;
            MosscobbleArmorSet = false;
            LightmushroomArmorSet = false;
        }

        public override void UpdateDead()
        {
            Wan = false;
        }

        public override void FrameEffects()
        {
            if (Wan)
            {
                player.legs = mod.GetEquipSlot("WanLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("WanBody", EquipType.Body);
                player.head = mod.GetEquipSlot("WanHead", EquipType.Head);
            }
        }
    }
}