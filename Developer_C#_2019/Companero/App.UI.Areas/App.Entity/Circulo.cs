using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    public class Circulo:Forma
    {
        private const double PI = Math.PI;
        public override void Calular()
        {
            Area = PI*Math.Pow(X,2);

            base.Calular();
        }
    }
}
