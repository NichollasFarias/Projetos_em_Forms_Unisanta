using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06_182348
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Variaveis Globais
        int[] x = new int[50];
        int i, j, aux, quant,soma = 0;
        Boolean mudar;
        #endregion

        #region Aviso!

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mudar == true)
            {
                Lb_Aviso.ForeColor = Color.Red;
                mudar = false;
            }
            else
            {
                Lb_Aviso.ForeColor = Color.White;
                mudar = true;
            }

        }



        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            i = 1;
            mudar = true;
        }
        #endregion

        #region Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
                
        }

        #endregion

        #region Sobre
        private void MnuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por: Nichollas Farias\nRA: 182348 \nDisciplina: Programação Visual e Games", "Sobre");
        }
        #endregion

        #region Validar a Quantidade
        private void Txt_Quantidade_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Txt_Quantidade.Text != "")
                {
                    quant = int.Parse(Txt_Quantidade.Text);
                    if (quant == 0)
                    {
                        MessageBox.Show("Valor incorreto, não pode ser nulo!\nDigite Novamente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Txt_Quantidade.Clear();
                        Txt_Quantidade.Focus();
                    }
                    if (quant > 50)
                    {
                        MessageBox.Show("Valor muito alto!\nDigite Novamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Quantidade.Clear();
                        Txt_Quantidade.Focus();
                    }
                }

                Lb_Ordinal.Text = i.ToString();
            }
            catch 
            {
                MessageBox.Show("Error","Error");
                return;
            }
        }
        #endregion

        #region Botão Calcular
        private void MnuCalcular_Click(object sender, EventArgs e)
        {
            double Mediafinal;

            for (int o = 0; o < i; o++)
            {
                soma += x[o];
            }


            Mediafinal = soma / quant;

            Lb_AlturaMedia.Text = Mediafinal.ToString();
        }
        #endregion

        #region Validar os Valores
        private void Txt_Valor_Validating(object sender, CancelEventArgs e)
        {
            Gb_Termos.Enabled = false;
            if (Txt_Valor.Text != "")
            {
                if (i < quant)
                {
                    x[i] = int.Parse(Txt_Valor.Text);
                    Lbx_Valores.Items.Add(x[i].ToString());
                    i++;
                    Lb_Ordinal.Text = i.ToString();
                    Txt_Valor.Clear();
                    Txt_Valor.Focus();
                }
                else
                {
                    Lb_Ordinal.Text = i.ToString();
                    x[quant] = int.Parse(Txt_Valor.Text);
                    Gb_Valor.Enabled = false;
                    Lbx_Valores.Items.Add(x[i].ToString());
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Verificar caracter
        public void Verificar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Botão Ordenar
        private void MnuOrdenar_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= quant - 1; i++)
                for (j = i + 1; j <= quant; j++)
                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
            for (i = 1; i <= quant; i++)
            {
                Lbx_Ordenados.Items.Add(x[i].ToString());
            }
        }
        #endregion

        #region Limpar
        private void MnuLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma?", "Limpar", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Txt_Quantidade.Clear();
                Txt_Valor.Clear();
                Lb_AlturaMedia.Text = "Resposta";
                Lb_Ordinal.Text = "0";
                Lbx_Valores.Items.Clear();
                Lbx_Ordenados.Items.Clear();
                Gb_Termos.Enabled = true;
                Gb_Valor.Enabled = true;
                i = 1;

            }
        }
        #endregion
    }
}
