using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    public class Triangulo:Forma
    {
        public override void Calular()
        {
            Area = X*Y/2;

            base.Calular();
        }
    }
}
