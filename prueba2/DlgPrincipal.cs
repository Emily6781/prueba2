using System;
using System.Drawing;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace prueba2
{
    //-------------------------------------------------------------------------
    //Diálogo del menúprincipal del proyecto de prácticas de PE23A
    //MVME 25/01/2023
    //-------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------
        //Dialogo de la prática 1.
        //-------------------------------------------------------------------------
        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            DlgPractica1 VentanaPractica1;

            VentanaPractica1 = new DlgPractica1();
            VentanaPractica1.Show();
        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            DlgProyectoEpi VentanaEpi;

            VentanaEpi = new DlgProyectoEpi();
            VentanaEpi.Show();
        }

        private void BtnPractica1_MouseHover(object sender, EventArgs e)
        {
            LblPruebaBoton1.Visible = true;
        }

        private void BtnPractica1_MouseLeave(object sender, EventArgs e)
        {
            LblPruebaBoton1.Visible = false;
        }
    }
}
