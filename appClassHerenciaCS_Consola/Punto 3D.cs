using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Punto3D : Punto
    {
        protected double z;

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
        public double Distancia(Punto3D p)
        {
            double d = 0;

            double dx = x - p.x;

            double dz = z - p.z;

            double cdx = Math.Pow(dx, 2);

            double cdz = Math.Pow(dz, 2);

            d = Math.Sqrt(cdx + cdz);

            return d;
        }
        public override string ToString()
        {
            return base.ToString() + " Z = " + z;
        }
    }
}