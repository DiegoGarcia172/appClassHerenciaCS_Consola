using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Punto3D : Punto
    {
        private double z;

        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double z) : base(x)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z;
        }
    }
}