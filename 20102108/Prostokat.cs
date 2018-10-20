using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20102108
{
    class Prostokat : Figura
    {
        private float a;
        private float b;

        public Prostokat(float a = 0.0f, float b = 0.0f)
        {
            this.a = a;
            this.b = b;
        }

        public override float Pole
        {
            get
            {
                return a * b;
            }
        }

        public override float Obwod
        {
            get
            {
                return 2 * a + 2 * b;
            }
        }

        public override string PrzedstawSie => "Prostokat";
       
    }
}

