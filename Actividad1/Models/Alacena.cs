using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Alacena
    {
        
        public double  Harina { get; private set; }

        public void ReponerHarina(double cantidad)
        {
            this.Harina = cantidad; /// harina += cantidad
        }
        public double Fruta { get; set; }
        public void reponerFruta(double cantidad)
        {
            this.Fruta = cantidad;//Fruta+= cantidad
        }
        public double TomarHarina (double requerido)
        {
            if (requerido <= Harina)
            {
                Harina -= requerido;
                return requerido;
            }
            else
            {
                double restante = Harina;
                Harina = 0;
                return restante;
            }
        }
    }

}
