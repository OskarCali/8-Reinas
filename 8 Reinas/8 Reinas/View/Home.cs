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
        public int Paso { get; set; }
        public int Iteracion { get; set; }

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
            toolStripBtnComplete.Enabled = false;
            toolStripBtnSteps.Enabled = false;
            toolStripBtnNextStep.Enabled = false;
            toolStripBtnNextIteration.Enabled = false;
            toolStripBtnViewChess.Enabled = false;

            int mejor = controller.completo(Dato, this);

            individuoDataGridView.Rows[mejor].Selected = true;
            individuoDataGridView.CurrentCell = individuoDataGridView.Rows[mejor].Cells[0];
            individuoDataGridView.FirstDisplayedScrollingRowIndex = individuoDataGridView.SelectedRows[0].Index;

            solucionBindingSource.DataSource = individuoBindingSource.Current;

            toolStripBtnComplete.Enabled = true;
            toolStripBtnSteps.Enabled = true;
            toolStripBtnViewChess.Enabled = true;

            MessageBox.Show("El mejor individuo es el: " + (mejor + 1), "SOLUCION", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

            controller.abrirTablero(this);
        }

        private void ToolStripBtnSteps_Click(object sender, EventArgs e)
        {
            toolStripBtnComplete.Enabled = false;
            toolStripBtnSteps.Enabled = false;
            toolStripBtnViewChess.Enabled = false;

            controller.pasos(Dato, this);

            toolStripBtnNextStep.Enabled = true;
            toolStripBtnNextIteration.Enabled = true;
        }

        private void ToolStripBtnNextStep_Click(object sender, EventArgs e)
        {
            int? mejor = controller.paso(Dato, this);

            if (mejor != null)
            {
                toolStripBtnNextStep.Enabled = false;
                toolStripBtnNextIteration.Enabled = false;

                individuoDataGridView.Rows[(int)mejor].Selected = true;
                individuoDataGridView.CurrentCell = individuoDataGridView.Rows[(int)mejor].Cells[0];
                individuoDataGridView.FirstDisplayedScrollingRowIndex = individuoDataGridView.SelectedRows[0].Index;

                solucionBindingSource.DataSource = individuoBindingSource.Current;

                toolStripBtnComplete.Enabled = true;
                toolStripBtnSteps.Enabled = true;
                toolStripBtnViewChess.Enabled = true;

                MessageBox.Show("El mejor individuo es el: " + (mejor + 1), "SOLUCION", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                controller.abrirTablero(this);
            }
        }

        private void ToolStripBtnNextIteration_Click(object sender, EventArgs e)
        {
            int? mejor = controller.iteracion(Dato, this);

            if (mejor != null)
            {
                toolStripBtnNextStep.Enabled = false;
                toolStripBtnNextIteration.Enabled = false;

                individuoDataGridView.Rows[(int) mejor].Selected = true;
                individuoDataGridView.CurrentCell = individuoDataGridView.Rows[(int) mejor].Cells[0];
                individuoDataGridView.FirstDisplayedScrollingRowIndex = individuoDataGridView.SelectedRows[0].Index;

                solucionBindingSource.DataSource = individuoBindingSource.Current;

                toolStripBtnComplete.Enabled = true;
                toolStripBtnSteps.Enabled = true;
                toolStripBtnViewChess.Enabled = true;

                MessageBox.Show("El mejor individuo es el: " + (mejor + 1), "SOLUCION", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                controller.abrirTablero(this);
            }
        }

        private void ToolStripBtnViewChess_Click(object sender, EventArgs e)
        {
            controller.abrirTablero(this);
        }
    }
}
