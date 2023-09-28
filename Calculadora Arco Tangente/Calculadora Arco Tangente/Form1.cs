using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Arco_Tangente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double V1, V2, R, V5, V6;

            V1 = double.Parse(txtV1.Text);
            V2 = double.Parse(txtV2.Text);

            V5 = V1 / V2;

            V6 = Math.Atan(V5);

            R = Math.Round( V6 * (180/Math.PI));

            lbR.Text = R.ToString();

        }
    }
}
