using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10_182348
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Analise.ValidaTE(Test_txt.Text) == true)
            {
                LB_res.ForeColor = Color.Green;
                LB_res.Text = "Titulo Correto";
            }
            else
            {
                LB_res.ForeColor = Color.Red;
                LB_res.Text = "Titulo ERRADO";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LB_res.Text = "Analisando...";
            LB_res.ForeColor = Color.Black;
            Test_txt.Clear();
            Test_txt.Focus();

        }
    }
}
