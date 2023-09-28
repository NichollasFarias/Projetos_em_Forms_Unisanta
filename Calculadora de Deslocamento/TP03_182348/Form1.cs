using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03_182348
{
    public partial class FM_TP03 : Form
    {

        #region Variáveis  Globais
        string msg, titulo;
        MessageBoxButtons BTS;
        MessageBoxIcon ICO;
        MessageBoxDefaultButton DF;
        #endregion

        #region Iniciação
        public FM_TP03()
        {
            InitializeComponent();
            TB_EspIni.Focus();
        }
        #endregion

        #region Lixo
        private void BT_Limp_Click(object sender, EventArgs e)
        {
            msg = "Gostaria de limpar?";
            titulo = "Limpar";
            BTS = MessageBoxButtons.YesNo;
            ICO = MessageBoxIcon.Question;
            DF = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, BTS, ICO, DF) == DialogResult.Yes)
            {
                TB_A.Clear();
                TB_EspIni.Clear();
                TB_Temp.Clear();
                TB_VI.Clear();
                LB_Res.Text = "";
                LB_Res02.Text = "";
                TB_EspIni.Focus();
            }
        }
        #endregion

        #region Sair
        private void BT_Sai_Click(object sender, EventArgs e)
        {
            msg = "Gostaria de Sair?";
            titulo = "Sair";
            BTS = MessageBoxButtons.YesNo;
            ICO = MessageBoxIcon.Warning;
            DF = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, BTS, ICO, DF) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Calculo
        private void BT_Calc_Click(object sender, EventArgs e)
        {
            double Espaço, VeloIn, Ace, Temp, Deslocamento, Velocidade;


            try
            {
                Espaço = double.Parse(TB_EspIni.Text);
                VeloIn = double.Parse(TB_VI.Text);
                Ace = double.Parse(TB_A.Text);
                Temp = double.Parse(TB_Temp.Text);

                if (Ace == 0)
                {
                    Deslocamento = Espaço + (VeloIn * Temp);
                    Velocidade = VeloIn;

                    LB_Res.Text = "O Delocamento é: " + Deslocamento.ToString() + "m";
                    LB_Res02.Text = "A Velocidade é: " + Velocidade.ToString() + "m/s";
                }
                else
                {
                    Deslocamento = Espaço * (VeloIn * (Temp + ((Ace * Math.Pow(Temp,2)/2))));
                    Velocidade = VeloIn + (Ace * Temp);

                    LB_Res.Text = "O Delocamento é: " + Deslocamento.ToString() + "m";
                    LB_Res02.Text = "A Velocidade é: " + Velocidade.ToString() + "m/s";
                }


            }

            catch
            {
                MessageBox.Show("Error 404");
                TB_A.Clear();
                TB_EspIni.Clear();
                TB_Temp.Clear();
                TB_VI.Clear();
                LB_Res.Text = "";
                LB_Res02.Text = "";
                TB_EspIni.Focus();

            }


        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            LB_Temp.Text = DateTime.Now.ToString();
        }
        #endregion


    }
}
