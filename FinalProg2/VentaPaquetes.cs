using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProg2
{
    public partial class VentaPaquetes : Form
    {
        public VentaPaquetes()
        {
            InitializeComponent();
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDestino.SelectedItem is Destino destinoSelected)
            {
                tbPrecioIndividual.Text = destinoSelected.GetPrecio().ToString("C2");
            }
            else
            {
                tbPrecioIndividual.Clear();
            }
        }
    }
}
