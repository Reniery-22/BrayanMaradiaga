using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrayanMaradiaga
{
    public partial class TercerFormulario : Form
    {
        public TercerFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numerosFuncion();
        }

        public void numerosFuncion ()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i %3 == 0)
                {
                    listBox1.Items.Add("Brayan");
                }
                if (i %5 == 0)
                {
                    listBox1.Items.Add("Maradiaga");
                }
                if (i %3 == 0 && i %5 == 0)
                {
                    listBox1.Items.Add("Brayan Maradiaga");
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
