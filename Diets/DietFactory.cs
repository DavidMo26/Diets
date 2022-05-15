using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    abstract class DietFactory
    {
        public abstract DietBase GetDiet();
    }
}
