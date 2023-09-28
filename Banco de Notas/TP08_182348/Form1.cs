using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP08_182348
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Analise
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

        #region Botão de Registrar
        private void button1_Click(object sender, EventArgs e)
        {
            int N01, N02, N03, N04;
            double MD;

            if (TbNome.Text.Length > 0 && TbSerie.Text.Length > 0 && TbNm.Text.Length > 0 && TbN1.Text.Length > 0 && TbN2.Text.Length > 0 && TbN3.Text.Length > 0 && TbN4.Text.Length > 0)
            {
                DgvRegistro.Enabled = true;
                DataRow novalinha = DtsResgistro.Tables["Diario"].NewRow();
                novalinha["Disciplina"] = TbNome.Text.ToString();
                novalinha["Serie"] = TbSerie.Text.ToString();
                novalinha["Matricula"] = TbNm.Text.ToString();
                novalinha["Nota 01"] = TbN1.Text.ToString();
                N01 = int.Parse(TbN1.Text);
                novalinha["Nota 02"] = TbN2.Text.ToString();
                N02 = int.Parse(TbN2.Text);
                novalinha["Nota 03"] = TbN3.Text.ToString();
                N03 = int.Parse(TbN3.Text);
                novalinha["Nota 04"] = TbN4.Text.ToString();
                N04 = int.Parse(TbN4.Text);

                MD = (N01 + N02 + N03 + N04) / 4;
                novalinha["Media"] = MD.ToString();

                if (MD >= 6)
                {
                    novalinha["Conceito"] = "Aprovado";
                }
                else
                {
                    novalinha["Conceito"] = "Reprovado";
                }

                DtsResgistro.Tables[0].Rows.Add(novalinha);

                TbN1.Clear();
                TbN2.Clear();
                TbN3.Clear();
                TbN4.Clear();
                TbNm.Clear();
                TbNome.Clear();
                TbSerie.Clear();

                DgvRegistro.Enabled = false;

            }
            else
            {
                MessageBox.Show("Todos os campos devem estar completos", "ERRO");
            }
        }
        #endregion

        #region Filtro
        private void TbFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (Cbprocura.Text)
            {
                case "Disciplina":
                    BscDiario.Filter = "Disciplina like '%" + TbFiltro.Text + "%'";
                    break;

                case "Serie":
                    BscDiario.Filter = "Serie like '%" + TbFiltro.Text + "%'";
                    break;

                case "Matricula":
                    BscDiario.Filter = "Matricula like '%" + TbFiltro.Text + "%'";
                    break;

                default:
                    TbFiltro.Clear();
                    MessageBox.Show("Opção invalida","Erro");
                    break;
            }
        }

        #endregion

        #region Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void linhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < DtsResgistro.Tables["Diario"].Rows.Count; i++)
                {
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Disciplina"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Serie"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Matricula"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Nota 01"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Nota 02"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Nota 03"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Nota 04"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Media"]);
                    SW.WriteLine(DtsResgistro.Tables["Diario"].Rows[i]["Conceito"]);
                    SW.WriteLine(string.Empty);
                }

                SW.Dispose();

            }
        }

        private void colunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < DtsResgistro.Tables["Diario"].Rows.Count; i++)
                {
                    string Disciplina = DgvRegistro.Rows[i].Cells[0].Value.ToString();
                    string Serie = DgvRegistro.Rows[i].Cells[1].Value.ToString();
                    string Matricula = DgvRegistro.Rows[i].Cells[2].Value.ToString();
                    string Nota01 = DgvRegistro.Rows[i].Cells[3].Value.ToString();
                    string Nota02 = DgvRegistro.Rows[i].Cells[4].Value.ToString();
                    string Nota03 = DgvRegistro.Rows[i].Cells[5].Value.ToString();
                    string Nota04 = DgvRegistro.Rows[i].Cells[6].Value.ToString();
                    string Media = DgvRegistro.Rows[i].Cells[7].Value.ToString();
                    string Conceito = DgvRegistro.Rows[i].Cells[8].Value.ToString();
                    SW.WriteLine(Disciplina + "|" + Serie + "|" + Matricula + "|" + Nota01 + "|" + Nota02 + "|" + Nota03 + "|" + Nota04 + "|" + Media + "|" + Conceito );
                }

                SW.Dispose();

            }
        }
    }
}
