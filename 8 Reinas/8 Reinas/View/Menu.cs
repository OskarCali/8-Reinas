using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_Reinas.Controller;
using _8_Reinas.View;

namespace _8_Reinas
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            ControllerFunction controller = new ControllerFunction();

            formHome home = new formHome();
            home.Dato = controller.datos(Convert.ToInt32(poblacionNumUD.Value), Convert.ToInt32(iteracionesNumUD.Value), Convert.ToDecimal(probCruceNumUD.Value), Convert.ToDecimal(probMutacionNumUD.Value));

            Hide();
            home.ShowDialog(this);
            Show();
        }

        private void PicBxAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por:\n\tOskar Cali\n\tCamilo Emmanuel Hernandez Rosales", "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
