using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Entity;

namespace App.UI.Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        //Circulo objCirculo = new Circulo();
        //Triangulo objTriangulo = new Triangulo();
        //Cuadrado objCuadrado = new Cuadrado();
        Forma objForma;

        #endregion

        private void rdoCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCuadrado.Checked)
            {
                label1.Text = "Lado:";
                label2.Visible = false;
                txtX.Text = "";
                txtY.Visible = false;
                objForma = new Cuadrado();
            }
        }

        private void rdoTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTriangulo.Checked)
            {
                label2.Visible = true;
                label1.Text = "Base:";
                txtX.Text = "";
                txtY.Visible = true;
                label2.Text = "Altura:";
                objForma = new Triangulo();
            }

        }

        private void rdoCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCirculo.Checked)
            {
                label2.Visible = false;
                label1.Text = "Radio:";
                txtX.Text = "";
                txtY.Visible = false;
                objForma = new Circulo();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
     

            objForma.X = Convert.ToDouble(txtX.Text);
            objForma.Y = Convert.ToDouble(txtY.Text.Trim() != "" ? txtY.Text.Trim() : "0");

            objForma.onDespuesCalcular += new Entity.Events.Listeners.DespuesCalcular(MostrarDatos);

            objForma.Calular();
        }

        private void MostrarDatos(object obj)
        {
                lblArea.Text = ((Forma)obj).Area.ToString();
        }
    }
}
