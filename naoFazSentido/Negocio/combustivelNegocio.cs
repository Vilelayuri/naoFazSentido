using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naoFazSentido.Negocio
{
    class combustivelNegocio
    {
        double gasolina;
        double etanol;
       

        public  string resultado;
        public void combustivelQCompensa(double g, double e)
        {
            this.gasolina = g;
            this.etanol = e;
            double porcentagem =this.gasolina * 70 / 100;
            double diferenca = this.etanol * 100 / this.gasolina;
            if (etanol<= porcentagem)
            {
              this.resultado = "Etanol";
            }
            else
            {
               this.resultado = "Gasolina";
            }
           
        }
        public double diferencas()
        {
            double diferenca = this.etanol * 100 / this.gasolina;
         
            return Math.Floor(diferenca);

        }
    }
}
