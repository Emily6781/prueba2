using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class DlgProyectoEpi : Form
    {
        public DlgProyectoEpi()
        {
            InitializeComponent();
        }

        private void BtnAjustes_MouseLeave(object sender, EventArgs e)
        {
            BtnAjustes.BackColor = Color.FromArgb(247, 175, 213);
            BtnAjustes.FlatStyle = FlatStyle.Flat;
            BtnAjustes.FlatAppearance.BorderColor = Color.FromArgb(248, 204, 227);

        }

        private void BtnFase1_MouseLeave(object sender, EventArgs e)
        {
            BtnFase1.BackColor = Color.FromArgb(247, 175, 213);
            BtnAjustes.FlatStyle = FlatStyle.Flat;
            BtnAjustes.FlatAppearance.BorderColor = Color.FromArgb(248, 204, 227);
        }

        private void BtnFase2_MouseLeave(object sender, EventArgs e)
        {
            BtnFase2.BackColor = Color.FromArgb(247, 175, 213);
            BtnAjustes.FlatStyle = FlatStyle.Flat;
            BtnAjustes.FlatAppearance.BorderColor = Color.FromArgb(248, 204, 227);
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            DlgProyect1 VentanaOpc;

            VentanaOpc = new DlgProyect1();
            VentanaOpc.Show();
        }

        private void BtnFase1_Click(object sender, EventArgs e)
        {
            DlgProyect2 VentanaF1;

            VentanaF1 = new DlgProyect2();
            VentanaF1.Show();
        }

        private void BtnFase2_Click(object sender, EventArgs e)
        {
            DlgProyect3 VentanaF2;

            VentanaF2 = new DlgProyect3();
            VentanaF2.Show();
        }

        private void BtnAjustes_MouseHover(object sender, EventArgs e)
        {
            BtnAjustes.BackColor = Color.Transparent;
            BtnAjustes.FlatStyle = FlatStyle.Flat;
            BtnAjustes.FlatAppearance.BorderColor = Color.FromArgb(248, 204, 227);
        }
    }
}
