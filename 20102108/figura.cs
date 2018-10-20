using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20102108
{
    public abstract class Figura
    {
        public abstract float Pole
        {
            get;
        }

        public abstract float Obwod
        {
            get;
        }
        public virtual string PrzedstawSie
        {
            get
            {
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return $"Figura = {PrzedstawSie}, Pole={Pole}, Obwod={Obwod}";
        }

       
    }
}
