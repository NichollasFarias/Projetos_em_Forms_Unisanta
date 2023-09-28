using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP11_182348
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BT_Valida_Click(object sender, EventArgs e)
        {
            if (Validacoe.ValidaCartao(TB_Numb.Text) == true)
            {
                LB_res.ForeColor = Color.Green;
                LB_res.Text = "Cartão Correto";
            }
            else
            {
                LB_res.ForeColor = Color.Red;
                LB_res.Text = "Cartão ERRADO";
            }
        }

        private void BT_limp_Click(object sender, EventArgs e)
        {
            LB_res.Text = "Validando...";
            LB_res.ForeColor = Color.White;
            TB_Numb.Clear();
            TB_Numb.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
