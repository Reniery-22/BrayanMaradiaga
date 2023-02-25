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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string fecha_Ini = "01/01/2023";
            DateTime fecha_Actu = new DateTime();
            fecha_Actu = DateTime.Parse(fecha_Ini.ToString());

            for (int i = 0; i < 12; i++)
            {
                listBox1.Items.Add(fecha_Actu.AddMonths(i) + " = " + (200000 * 0.015) * (i+1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
