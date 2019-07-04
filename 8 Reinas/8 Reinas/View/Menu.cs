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
            home.Dato = controller.datos(Convert.ToInt32(poblacionNumUD.ToString()), Convert.ToInt32(iteracionesNumUD.ToString()), Convert.ToDecimal(probCruceNumUD.ToString()), Convert.ToDecimal(probMutacionNumUD.ToString()));

            Hide();
            home.ShowDialog(this);
            Show();
        }
    }
}
