using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Adaline
    {
        float[] pesos;
        float ratApr;

        public Adaline(float ra)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            pesos = new float[3];
            for (int i = 0; i < 3; i++)
            {
                pesos[i] = 5 - (float)random.NextDouble() * 10;
            }
            ratApr = ra * 2f;
        }

        public float[] Pesos
        {
            get
            {
                return pesos;
            }
        }

        public float RA
        {
            set
            {
                ratApr = value * 2f;
            }
        }

        public void actualizar(float des, float x, float y)
        {
            float sig = sigmoide(x, y);

            pesos[0] += (ratApr * (des - sig) * sig * (1f - sig) * -1);
            pesos[1] += (ratApr * (des - sig) * sig * (1f - sig) * x);
            pesos[2] += (ratApr * (des - sig) * sig * (1f - sig) * y);
        }

        public float sigmoide(float x, float y)
        {
            float av = pesos[1] * x + pesos[2] * y - pesos[0];

            return 1f / (1 + (float)Math.Pow(Math.E, -av));
        }
    }
}
