using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Formulas_eEpecificas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PnlFormulasMRU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlMRU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMRU.Visible = false;
            pnlFormulasMRU.Visible = false;
        }

        private void cmbIngresarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
