using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMediaAluno
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        public void limparDados()
        {
            txtNome.Text = "";
            N1.Text = "";
            N2.Text = "";
            N3.Text = "";
            N4.Text = "";
            Media.Text = "";
            Resultado.Text = "";
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Double n1, n2, n3, n4, media;
            string resultado;
            string nome;
            nome = txtNome.Text;
            if (nome == "")
            {
                MessageBox.Show("Informe um Nome");
            }
            else
            {
                if ((N1.Text == "") || (N2.Text == "") || (N3.Text == "") || (N4.Text == ""))
                {
                    MessageBox.Show("Informe Todas as Notas");
                }
                else
                {
                    n1 = Convert.ToDouble(N1.Text);
                    n2 = Convert.ToDouble(N2.Text);
                    n3 = Convert.ToDouble(N3.Text);
                    n4 = Convert.ToDouble(N4.Text);

                    media = ((n1 + n2 + n3 + n4) / 4);
                    Media.Text = "Média " + (media.ToString());

                    if (media >= 7)
                    {
                        resultado = "Aprovado !!";
                    }
                    else
                    {
                        resultado = "Reprovado !!!";
                    }

                    Resultado.Text = "O aluno " + nome + " foi " + resultado.ToString();
                }
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            limparDados();
        }
    }
}