using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP05_182348
{
    public partial class Form1 : Form
    {

        #region Variavel Global
        int contador = 1;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Data/Tempo
        private void TMR_Data_Tick(object sender, EventArgs e)
        {
            LB_Data.Text = DateTime.Today.ToString();
        }
        #endregion

        #region Animação
        private void Animação_Tick(object sender, EventArgs e)
        {
            contador = contador % 9 + 1;
            PBX_Circuito.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\res0" + Convert.ToString(contador) + ".png");
        }
        #endregion

        #region Verificar Char
        private void Verificar(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }

        }
        #endregion

        #region Botão Calcular
        private void BT_Calc_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, hz2, af, uf, hz1, vp;

            try
            {
                af = double.Parse(TB_Af.Text);
                uf = double.Parse(TB_uF.Text);
                hz1 = double.Parse(TB_Hz.Text);
                vp = double.Parse(TB_vp.Text);
            }
            catch 
            {
                MessageBox.Show("Erro no Valores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_Af.Focus();
                return;
            }

            try
            { 
                for (int i = 0; i < 5; i++)
                {
                    r1 = (Math.Sqrt(2)) / (2 * af * 2 * Math.PI * uf * hz1);
                    r2 = af * r1;
                    r3 = r2 / (af + 1);
                    hz2 = 2 * (af + 1) * hz1;

                    LBX_R1.Items.Add("R1 = " + r1.ToString("#0.0000"));
                    LBX_R2.Items.Add("R2 = " + r2.ToString("#0.0000"));
                    LBX_R3.Items.Add("R3 = " + r3.ToString("#0.0000"));
                    LBX_Cap.Items.Add("Cap 02 = " + hz2.ToString("#0.0000"));

                    af += vp;
                }
            }
            catch
            {
                MessageBox.Show("Erro no cálculo", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        #region Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Fechando o APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Limpar

        private void BT_Limp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Fechando o APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TB_Af.Clear();
                TB_Hz.Clear();
                TB_uF.Clear();
                TB_vp.Clear();
                LBX_R1.Items.Clear();
                LBX_R2.Items.Clear();
                LBX_R3.Items.Clear();
                LBX_Cap.Items.Clear();
                TB_Af.Focus();

            }
        }
        #endregion
    }
}
