using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPergunta2 : Form
    {

        //Recebe nome e pontuação
        public FrmPergunta2(string nome, string texto)
        {
            
            InitializeComponent();
            label2.Text = nome;
            label5.Text = texto;

        }

        // Atribui ponto por reposta correta e mostra a alternativa exata
        private void button1_Click(object sender, EventArgs e)
        {
            //Var contar e atribuir os pontos
            int cont = 0;

            if (radioButton1.Checked)
            {

                radioButton5.Visible = true;
                cont = Convert.ToInt16(label5.Text);
                

            }
            if (radioButton2.Checked)
            {
                radioButton5.Visible = true;
                cont = Convert.ToInt16(label5.Text);
            }
            if (radioButton3.Checked)
            {
                radioButton5.Visible = true;
                cont = Convert.ToInt16(label5.Text);
                cont++;
            }
            if (radioButton4.Checked)
            {
                radioButton5.Visible = true;
                cont = Convert.ToInt16(label5.Text);
            }

                label5.Text = Convert.ToString(cont);
                button1.Visible = false;
                button2.Visible = true;

            

        }

        //Salva nome e Pontuação, próxima tela.
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FrmPergunta3(label2.Text, label5.Text);
            form.Show();
            this.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
