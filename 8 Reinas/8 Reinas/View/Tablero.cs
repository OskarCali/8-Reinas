using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Reinas.View
{
    public partial class formTablero : Form
    {
        public List<int> Reinas { get; set; }

        public formTablero(int num)
        {
            InitializeComponent();
            Text += " - " + num;
        }

        private void FormTablero_Load(object sender, EventArgs e)
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    var btn = new Button();
                    btn.SetBounds(x * 70, y * 70, 70, 70);
                    btn.Enabled = false;

                    if (y % 2 == 0)
                    {
                        btn.BackColor = x % 2 == 0 ? Color.LightSlateGray : Color.White;
                    }
                    else
                    {
                        btn.BackColor = x % 2 == 0 ? Color.White : Color.LightSlateGray;
                    }

                    if (Reinas[y] == (x+1))
                    {
                        btn.BackgroundImage = new Bitmap(_8_Reinas.Properties.Resources.reina);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    Controls.Add(btn);

                    Width = btn.Right + 20;
                    Height = btn.Bottom + 40;
                }
            }
        }
    }
}
