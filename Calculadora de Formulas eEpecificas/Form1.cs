using Infrastructure;
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

                    pnlMRU.Visible = true;
                    pnlCaidaLibre.Visible = false;
                    break;

                case 1:
                    pnlMRU.Visible = false;
                    pnlCaidaLibre.Visible = true;
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


            rtbHistorial.Text = $"" + data2 + "la Velocidad es igual a: " + mru.Velocidad(txtDistanciadevel.Text, txtTiempodevel.Text)+ " en su respectiva medida";


        }

        private void btnCalcDistMRU_Click(object sender, EventArgs e)
        {

            string data2 = "";
            string data1 = "";
            MRU mru = new MRU();

            data1 = rtbHistorial.Text;
            data2 = data1;


            rtbHistorial.Text= $""+data2+"         La distancia es igual a: " + mru.Distancia(txtVeldeDis.Text, txtTiempodeDis.Text)+ " En su respectiva medida";
                
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data2 = "";
            string data1 = "";
            MRU mru = new MRU();

            data1 = rtbHistorial.Text;
            data2 = data1;


            rtbHistorial.Text = $"" + data2 + "         La distancia es igual a: " + mru.Tiempo(txtDistanciadeTiempo.Text, txtVelocidaddetiempo.Text) + " En su respectiva medida";






        }

        private void pnlCaidaLibre_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
