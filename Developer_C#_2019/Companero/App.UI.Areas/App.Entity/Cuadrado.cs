using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    public class Cuadrado:Forma
    {
        public override void Calular()
        {
            Area = Math.Pow(X, 2);

            base.Calular();
        }
    }
}
