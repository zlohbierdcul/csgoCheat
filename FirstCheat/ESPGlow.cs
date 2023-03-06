using System;
namespace FirstCheat
{
	public class ESPGlow
	{
		public ESPGlow()
		{
		}

        struct GlowStructEnemy
        {
            float red = 1.0f;
            float green = 0.0f;
            float blue = 0.0f;
            float alpha = 1.0f;
            uint[] padding = new uint[8];
            float unknown = 1.0f;
            uint[] padding2 = new uint[4];
            Boolean renderOccluded = true;
            Boolean renderUnoccluded = false;
            Boolean fullBloom = false;

            public GlowStructEnemy()
            {
            }
        }

        struct GlowStructLocal
        {
            float red = 1.0f;
            float green = 0.0f;
            float blue = 0.0f;
            float alpha = 1.0f;
            uint[] padding = new uint[8];
            float unknown = 1.0f;
            uint[] padding2 = new uint[4];
            Boolean renderOccluded = true;
            Boolean renderUnoccluded = false;
            Boolean fullBloom = false;

            public GlowStructLocal() { }
        }

        GlowStructEnemy glowEnemy;
        GlowStructLocal glowLocal;


        UIntPtr getLocalPlayer()
        {
            return 
        }
    }
}

