using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_182348
{
    public partial class Frm01 : Form
    {
        public Frm01()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            // Labels
            LB01.Text = "0 Ω";
            LB02.Text = "0 Ω";
            LB03.Text = "0 Ω";
            LB04.Text = "0 Ω";
            LB05.Text = "0 Ω";
            LB06.Text = "0 Ω";

            // TextBox
            TB01.Text = "";
            TB02.Text = "";
            TB03.Text = "";
        }

        private void BT03_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            };
        }

        private void BT01_Click(object sender, EventArgs e)
        {
            int R1,R2,R3,R4,R5,R6;

            // Atribuindo Valor para Variaveis Iniciais

            R1 = int.Parse(TB01.Text);
            R2 = int.Parse(TB02.Text);
            R3 = int.Parse(TB03.Text);

            //Atribuindo Valor Iniciais a Labels Iniciais
            LB01.Text = R1 + "Ω";
            LB02.Text = R2 + "Ω";
            LB03.Text = R3 + "Ω";

            // Conta para Novas Variaveis

            R4 = (R1 * R2) / (R1 + R2 + R3);
            R5 = (R2 * R3) / (R1 + R2 + R3);
            R6 = (R3 * R1) / (R1 + R2 + R3);

            // Enviando resposta para Labels

            LB04.Text = R4 + "Ω";
            LB05.Text = R5 + "Ω";
            LB06.Text = R6 + "Ω";

        }

        private void BT02_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
