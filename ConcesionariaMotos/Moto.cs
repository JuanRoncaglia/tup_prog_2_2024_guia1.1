using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaMotos
{
    internal class Moto
    {

        public string Marca { get; private set; }

        public int Modelo { get; private set; }

        public double ValorFabricacion { get; private set; }


        #region propiedades
        public Moto(string marca, int modelo, double valorFabricacion)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoactual,double vidaUtil)
        { 
            return ValorFabricacion - (ValorFabricacion * (añoactual - Modelo) / vidaUtil);
           
        }

        public double CalcularDepreciacionAnual(int anoACalcular, double tasaDepreciacion)
        {

            return ValorFabricacion * (Math.Pow(1 - 0.1, anoACalcular - Modelo));

        }

        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion,7:f2}";
        }
        #endregion
    }
}
