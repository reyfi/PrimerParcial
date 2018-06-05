using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using rPrimerParcial.UI;
using rPrimerParcial.DAL;
using rPrimerParcial.BLL;


namespace rPrimerParcial
{
    public partial class MainParcial : Form
    {
        public MainParcial()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consulta.Consulta c = new UI.Consulta.Consulta();
            c.Show();
        }
    }
}
