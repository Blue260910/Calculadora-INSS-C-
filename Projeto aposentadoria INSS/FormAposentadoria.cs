using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_aposentadoria_INSS
{
    public partial class FormAposentadoria : Form
    {
        public FormAposentadoria()
        {
            InitializeComponent();
        }

        private void tempTrab_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione o sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idade;
            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int anosDeContribuicao;
            if (!int.TryParse(tempTrab.Text, out anosDeContribuicao))
            {
                MessageBox.Show("Por favor, insira um tempo de contribuição válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sexo = cmbSexo.SelectedItem.ToString();

            int idadeMinima, tempoMinimoContribuicao, tempoContribuicaoTotal;

            if (sexo == "Masculino")
            {
                idadeMinima = 65;
                tempoMinimoContribuicao = 20;
                tempoContribuicaoTotal = 35;
            }
            else
            {
                idadeMinima = 62;
                tempoMinimoContribuicao = 15;
                tempoContribuicaoTotal = 30;
            }

            bool podeAposentarPorIdade = idade >= idadeMinima && anosDeContribuicao >= tempoMinimoContribuicao;

            bool podeAposentarPorTempo = anosDeContribuicao >= tempoContribuicaoTotal;

            if (podeAposentarPorIdade)
            {
                lblResultado.Text = "Parabéns! Você pode se aposentar por idade.";
            }
            else if (podeAposentarPorTempo)
            {
                lblResultado.Text = "Parabéns! Você pode se aposentar por tempo de contribuição.";
            }
            else
            {
                int anosFaltandoIdade = Math.Max(0, idadeMinima - idade);
                int anosFaltandoContribuicao = Math.Max(0, tempoMinimoContribuicao - anosDeContribuicao);
                int anosFaltandoTotal = Math.Max(0, tempoContribuicaoTotal - anosDeContribuicao);

                lblResultado.Text = $"Faltam aproximadamente {Math.Max(anosFaltandoIdade, Math.Min(anosFaltandoContribuicao, anosFaltandoTotal))} anos para se aposentar.";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
