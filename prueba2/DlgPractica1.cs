using System;
using System.Windows.Forms;

namespace prueba2
{
    //-------------------------------------------------------------------------
    //Diálogo del la práctica de la materia de PE23A.
    //EMVM 13/02/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPractica1 : Form
    {
        //-------------------------------------------------------------------------
        //Constructor
        //-------------------------------------------------------------------------
        public DlgPractica1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------
        //Llena la matriz a partir de los datos capturados.
        //-------------------------------------------------------------------------
        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            int NumRenglones;
            int NumColumnas;

            NumRenglones = Convert.ToInt32(TbxNumRenglones.Text);
            NumColumnas = Convert.ToInt32(TbxNumColumnas.Text);

            for (int r = 0; r < NumRenglones; r++)
            {
                for (int c = 0; c < NumColumnas; c++)
                {
                    RtbMatriz.Text = RtbMatriz.Text + (r + 1);
                }
                RtbMatriz.Text = RtbMatriz.Text + "\n";
            }

        }
    }
}
