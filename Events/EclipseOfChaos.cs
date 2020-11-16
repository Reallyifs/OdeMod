using Microsoft.Xna.Framework.Graphics;
using System;

namespace OdeMod.Events
{
    public class EclipseOfChaos
    {
        public static bool Happening;

        internal static Action ProcessingAction;
        internal static Texture2D SunTexture;

        internal static void Load()
        {
            Happening = false;
            SunTexture = OdeMod.Instance.GetTexture("Images/EclipseOfChaos/WontonSun");
            ProcessingAction = new Action(delegate { });
        }

        internal static void Unload()
        {
            Happening = false;
            SunTexture = null;
            ProcessingAction = null;
        }
    }
}