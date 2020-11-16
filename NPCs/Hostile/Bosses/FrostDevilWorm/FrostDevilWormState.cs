using Microsoft.Xna.Framework;
using StarlitRainbowCollection;
using Terraria;
using Terraria.ModLoader;

namespace OdeMod.NPCs.Hostile.Bosses.FrostDevilWorm
{
    public partial class FrostDevilWormHead : ModNPC
    {
        private int timer2 = 0;
        private Vector2 recordVector2 = default(Vector2);

        public void State0()
        {
            timer2++;
            if (timer2 >= 20 && timer2 <= 60)
            {
                npc.velocity.Y += 0.2f;
            }
            if (timer2 >= 65 && timer2 <= 90)
            {
                npc.Approach(TPlayer.Center, 0.4f);
            }
            if (timer2 >= 95 && timer2 <= 110)
            {
                if (npc.velocity.Length() > 5)
                    npc.velocity *= 0.97f;
            }
            if(timer2 == 150)
            {
                if(TPlayer.Center.Y - npc.Center.Y > 300)
                {
                    npc.ChangeVelocityTo(TPlayer.Center, 5);
                }
            }
            if (timer2 == 180)
            {
                TransformState();
            }
        }

        public void State1()
        {
            timer2++;
            if (timer2 % 30 == 0)
            {
                recordVector2 = TPlayer.Center;
            }
            if(timer2 % 60 == 10)
            {
                Barrage0(Main.rand.Next(2, 4));
            }
            if (timer2 > 10)
            {
                npc.Orbit(recordVector2, 10, 1);
            }
            if (timer2 == 310)
            {
                TransformState();
            }
        }

        public void State2()
        {
            timer2++;
            if(timer2 % 80 == 20)
            {
                Vector2 pos = Geometry.GetRandomPosInCircle(npc.Center, 120);
                NPC.NewNPC((int)pos.X, (int)pos.Y, mod.NPCType("FrostProbe"));
            }
            if (timer2 == 270)
            {
                TransformState();
            }
        }

        public void State3()
        {
            timer2++;
            if (timer2 == 20)
            {
                npc.ChangeVelocityTo(TPlayer.Center, 8);
            }
            if (timer2 >= 60 && timer2 <= 75)
            {
                if (npc.velocity.Length() > 5) npc.velocity *= 0.97f;
            }
            if (timer2 == 120)
            {
                Barrage0(Main.rand.Next(3, 5));
            }
            if (timer2 == 200)
            {
                TransformState();
            }
        }

        public void State4()
        {
            timer2++;
            if(timer2 % 100 == 30)
            {
                npc.Approach(TPlayer.Center + Geometry.GetVector(timer2.ToRadian(), 450));
            }
            if(timer2 == 370)
            {
                Vector2 pos = Geometry.GetRandomPosInCircle(TPlayer.Center, 700);
                NPC.NewNPC((int)pos.X, (int)pos.Y, mod.NPCType("ForstWormHead"));
            }
            if (timer2 == 400)
            {
                TransformState();
            }
        }

        public void State5()
        {
            timer2++;
            if (timer2 == 10)
            {
                recordVector2 = TPlayer.Center;
            }
            if (timer2 >= 30 && timer2 <= 100 && timer2 % 2 == 1)
            {
                npc.Orbit(recordVector2, 9);
            }
            if (timer2 == 150)
            {
                for (int i = 0; i < 4; i++)
                {
                    Vector2 pos = npc.Center + Geometry.GetVector(i * 90.ToRadian(), 120);
                    NPC.NewNPC((int)pos.X, (int)pos.Y, mod.NPCType("FrostProbe2"));
                }
            }
            if (timer2 == 200)
            {
                TransformState();
            }
        }

        public void TransformState()
        {
            timer2 = 0;
            counter = (counter + 1) % states.Length;
        }
    }
}