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
using _8_Reinas.Model;

namespace _8_Reinas.View
{
    public partial class formHome : Form
    {
        public Dato Dato { get; set; }
        private int _paso { get; set; }
        ControllerFunction controller = new ControllerFunction();

        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            toolStripBtnNextStep.Enabled = false;
            toolStripBtnNextIteration.Enabled = false;
            toolStripBtnViewChess.Enabled = false;
        }

        private void ToolStripBtnComplete_Click(object sender, EventArgs e)
        {
            toolStripBtnSteps.Enabled = false;
            toolStripBtnNextStep.Enabled = false;
            toolStripBtnNextIteration.Enabled = false;
            toolStripBtnViewChess.Enabled = false;

            int mejor = controller.completo(Dato, this);

            individuoDataGridView.Rows[mejor].Selected = true;
            individuoDataGridView.CurrentCell = individuoDataGridView.Rows[mejor].Cells[0];
            individuoDataGridView.FirstDisplayedScrollingRowIndex = individuoDataGridView.SelectedRows[0].Index;

            toolStripBtnSteps.Enabled = true;
            toolStripBtnViewChess.Enabled = true;

            MessageBox.Show("El mejor individuo es el: " + (mejor + 1), "SOLUCION", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

            controller.abrirTablero(this);
        }

        private void ToolStripBtnSteps_Click(object sender, EventArgs e)
        {
            toolStripBtnComplete.Enabled = false;
            toolStripBtnNextStep.Enabled = true;
            toolStripBtnNextIteration.Enabled = true;
            toolStripBtnViewChess.Enabled = false;

            _paso = controller.pasos(Dato, this);
        }

        private void ToolStripBtnNextStep_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripBtnNextIteration_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripBtnViewChess_Click(object sender, EventArgs e)
        {
            controller.abrirTablero(this);
        }
    }
}
