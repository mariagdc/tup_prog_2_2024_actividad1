using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        Cocina miCocina;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Alacena alacena = new Alacena();
            Amasador amasador = new Amasador();

            miCocina = new Cocina(alacena, amasador);
            
            
        }

        private void ReponerIngrediente_Click(object sender, EventArgs e)
        {
            Alacena a = miCocina.Alacena;
            a.ReponerHarina(50);
            a.reponerFruta(100);
        }

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            Alacena a = miCocina.Alacena;
            double harina = Convert.ToDouble(tbxharina.Text);
            double fruta = Convert.ToDouble(tbxfruta.Text);
            double h = a.TomarHarina(harina);
            double f = a.tomarFruta(fruta);
        }
    }
}
