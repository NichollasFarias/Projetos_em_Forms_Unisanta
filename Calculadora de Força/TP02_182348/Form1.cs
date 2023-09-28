using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02_182348
{
    public partial class Form1 : Form
    {
        #region Variáveis  Globais
        string msg, titulo;
        MessageBoxButtons BTS;
        MessageBoxIcon ICO;
        MessageBoxDefaultButton DF;
        #endregion
        #region Iniciação do Component
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Comandos/Botão/Envio de Valor
        private void BT_Cal_Click(object sender, EventArgs e)
        {

            // Definindo Variaveis
            double massa, constante, força, angulo, distancia, resultado, angulorad;

            // Aplicando Valores
            massa = double.Parse(TB_Massa.Text);
            constante = double.Parse(TB_u.Text);
            força = double.Parse(TB_F.Text);
            angulo = double.Parse(TB_An.Text);
            distancia = double.Parse(TB_Dis.Text);

            // Calculo
            angulorad = (angulo * Math.PI) / 180;
            resultado = constante * (massa * 9.8 - força * Math.Sin(angulorad)) * distancia * Math.Cos(angulorad);

            // Enviando Resultado
            LB_Res.Text = "Fat = " + resultado.ToString() + "N";

        }
        #endregion
        #region Botão Sair
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
        #region Botão Limpar
        private void BT_Lim_Click(object sender, EventArgs e)
        {
            msg = "Gostaria de limpar?";
            titulo = "Limpar";
            BTS = MessageBoxButtons.YesNo;
            ICO = MessageBoxIcon.Question;
            DF = MessageBoxDefaultButton.Button2;

            if(MessageBox.Show(msg,titulo,BTS,ICO,DF) == DialogResult.Yes)
            {
                TB_An.Clear();
                TB_Dis.Clear();
                TB_F.Clear();
                TB_Massa.Clear();
                TB_u.Clear();
                LB_Res.Text = "";
                TB_Massa.Focus(); 
            }

        }
        #endregion
    }
}
