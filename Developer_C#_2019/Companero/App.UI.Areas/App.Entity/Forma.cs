using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Entity.Events.Listeners;

namespace App.Entity
{
    public class Forma
    {
        public event DespuesCalcular onDespuesCalcular;
        public double X { set; get; }
        public double Y { set; get; }
        public double Area { set; get; }
        public virtual void Calular() 
        {
            if (onDespuesCalcular != null)
            {
                onDespuesCalcular(this);
            }
        }

    }
}
