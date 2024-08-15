using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcesionariaMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            int añoACalcular = Convert.ToInt32(nupAnioAcutal.Value);
            double valorFabricacion = Convert.ToDouble(tbValorFab.Text);
            double tasaDepreciacion = Convert.ToDouble(tbTasaDepre.Text);
            int vidaUtil = Convert.ToInt32((tbVidaUtil.Text).ToString());

            Moto miMoto = new Moto(marca, modelo, valorFabricacion);

            VerResultados vResultados = new VerResultados();

            vResultados.lbResultadoFin.Items.Add(miMoto.VerDescripcion());


            double DeprLineal = miMoto.CalcularDepreciacionLineal(añoACalcular, vidaUtil);

            vResultados.lbResultadoFin.Items.Add($"Depreciación Lineal: { DeprLineal,10:f2}");

            double DeprAnual = miMoto.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);

            vResultados.lbResultadoFin.Items.Add($"Depreciación Anual: {DeprAnual,10:f2}");

            vResultados.ShowDialog();

        }

    }
}
