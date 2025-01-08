using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02practise
{
    internal struct Ponit
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

     

        #region Methods
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion
    }
}
