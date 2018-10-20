using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20102108
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(float a) : base(a, a)
        {

        }

        public override string PrzedstawSie => "Kwadrat";
    }
}
