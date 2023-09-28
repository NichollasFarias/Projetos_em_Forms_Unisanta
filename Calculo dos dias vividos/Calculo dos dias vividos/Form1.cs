using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_dos_dias_vividos
{
    public partial class Frm_TP01 : Form
    {
        public Frm_TP01()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            const int Ano = 365;
            int idade, AVV;
            string Nome;

            Nome = textBox1.Text;
            idade = int.Parse(textBox2.Text);
            AVV = Ano * idade;


            label3.Text = Nome + " seu tempo de vida vivido foi de " + AVV.ToString();

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
