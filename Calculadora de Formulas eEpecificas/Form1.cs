using Infrastructure;
using Infrastructure.CaidaLibre;
using Infrastructure.Ley2Newton;
using Infrastructure.Temperatura;
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
            lblInfoMRU.Visible = false;


            pnlFuerza.Visible = false;
            pnlFormulaGeneral.Visible = false;
            pnlFormulasMRUvel.Visible = false;
            pnlMRUtiempo.Visible = false;
            pnlMRU.Visible = false;
            pnlCaidaLibre.Visible = false;
            pnlFormulasMRU.Visible = false;
      
        }

        private void cmbIngresarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIngresarTipo.SelectedIndex)
            {
                case 0:


                    lblInfoMRU.Visible = true;

                    pnlMRUtiempo.Visible = false;
                    pnlFormulasMRUvel.Visible = false;
                    pnlFormulasMRU.Visible = false;


                    pnlMRU.Visible = true;
                    pnlCaidaLibre.Visible = false;
                    pnlFormulaGeneral.Visible = false;
                    pnlFuerza.Visible = false;

                    break;

                case 1:
                    lblInfoMRU.Visible = false;

                    pnlMRUtiempo.Visible = false;
                    pnlFormulasMRUvel.Visible = false;
                    pnlFormulasMRU.Visible = false;


                    pnlMRU.Visible = false;
                    pnlCaidaLibre.Visible = true;
                    pnlFormulaGeneral.Visible = false;
                    pnlFuerza.Visible = false;
                    break;

                case 2:

                    lblInfoMRU.Visible = false;


                    pnlMRUtiempo.Visible = false;
                    pnlFormulasMRUvel.Visible = false;
                    pnlFormulasMRU.Visible = false;

                    pnlMRU.Visible = false;
                    pnlCaidaLibre.Visible = false;
                    pnlFormulaGeneral.Visible = true;
                    pnlFuerza.Visible = false;
                    break;

                case 3:

                    lblInfoMRU.Visible = false;


                    pnlMRUtiempo.Visible = false;
                    pnlFormulasMRUvel.Visible = false;
                    pnlFormulasMRU.Visible = false;

                    pnlMRU.Visible = false;
                    pnlCaidaLibre.Visible = false;
                    pnlFormulaGeneral.Visible = false;
                    pnlFuerza.Visible = true;

                    break;


            }
            
        }

        private void cmbTipoMRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoMRU.SelectedIndex)
            {
                case 0:
                    
                    pnlFormulasMRU.Visible = true;
                    pnlFormulasMRUvel.Visible = false;
                    pnlMRUtiempo.Visible = false;

                    break;
                case 1:

                    pnlFormulasMRU.Visible = false;
                    pnlFormulasMRUvel.Visible = true;
                    pnlMRUtiempo.Visible = false;


                    break;
                case 2:
                    pnlFormulasMRU.Visible = false;
                    pnlFormulasMRUvel.Visible = false;
                    pnlMRUtiempo.Visible = true;
                    break;
            }
        }

        private void btncalcVelMRU_Click(object sender, EventArgs e)
        {
            

                string data2 = "";
                string data1 = "";
                MRU mru = new MRU();



                data1 = rtbHistorial.Text;
                data2 = data1;

            try
            {
                rtbHistorial.Text = $"" + data2 + "         la Velocidad es igual a: " + mru.Velocidad(txtDistanciadevel.Text, txtTiempodevel.Text) + " en su respectiva medida";
            }
             catch (FormatException)
            {
                MessageBox.Show($"Valor inválido");
            }

        }

        private void btnCalcDistMRU_Click(object sender, EventArgs e)
        {

            string data2 = "";
            string data1 = "";
            MRU mru = new MRU();

            data1 = rtbHistorial.Text;
            data2 = data1;

            try
            {
              rtbHistorial.Text= $""+data2+"         La distancia es igual a: " + mru.Distancia(txtVeldeDis.Text, txtTiempodeDis.Text)+ " En su respectiva medida";
              
            }
            catch (FormatException)
            {
                MessageBox.Show($"Valor inválido");
            }
                
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data2 = "";
            string data1 = "";
            MRU mru = new MRU();

            data1 = rtbHistorial.Text;
            data2 = data1;


            

            try {
                rtbHistorial.Text = $"" + data2 + "         El tiempo es igual a: " + mru.Tiempo(txtDistanciadeTiempo.Text, txtVelocidaddetiempo.Text) + " En su respectiva medida";

            }
            catch (FormatException)
            {
                MessageBox.Show($"Valor inválido");
            }


}

        private void pnlCaidaLibre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string data2 = "";
            string data1 = "";
            CaidaLibre caidalibre = new CaidaLibre();

            data1 = rtbHistorial.Text;
            data2 = data1;

            try {
                
                rtbHistorial.Text = $"" + data2 + "         La altura es igual a: " + caidalibre.Altura1(txtVelocidadInicialCaida.Text, txtTiempoCaida.Text) + " En su respectiva medida";
                 
            
            }
            catch (FormatException)
            {
                
                MessageBox.Show($"Valor inválido");

            }
            
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularForm_Click(object sender, EventArgs e)
        {

            string data2 = "";
            string data1 = "";
            FormulaGeneral formulageneral = new FormulaGeneral();

            data1 = rtbHistorial.Text;
            data2 = data1;

            try { 
            rtbHistorial.Text = $"" + data2 + "         el valor de la formula general Para" +
                " X1 Y X2 es: " + formulageneral.FormGenPos(txtAForm.Text, txtBForm.Text, txtCForm.Text) + " y "+ formulageneral.FormGenNeg(txtAForm.Text, txtBForm.Text, txtCForm.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Valor inválido");
            }


}

        private void btnCalcularFuerza_Click(object sender, EventArgs e)
        {

            string data2 = "";
            string data1 = "";
            Fuerza fuerza = new Fuerza();

            data1 = rtbHistorial.Text;
            data2 = data1;

            try { 
            rtbHistorial.Text = $"" + data2 + "         El valor de la Fuerza equivale a " +fuerza.Fuerza1(txtMasaNewton.Text, txtAcelNewton.Text)+ " Newton";
            }
            catch (FormatException)
            {
                MessageBox.Show($"Valor inválido");
            }

}
    }
}
