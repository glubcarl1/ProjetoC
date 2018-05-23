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
    public partial class FrmPergunta3 : Form
    {
        // Recebe nome e pontuação.
        public FrmPergunta3(string nick, string text)
        {
            InitializeComponent();
            label2.Text = nick;
            label5.Text = text;
        }

        // Atribui ponto por reposta correta e mostra a opção correta.
        private void button1_Click(object sender, EventArgs e)
        {
            //Var contar e atribuir pontos
            int cont = 0;

            if (radioButton1.Checked)
            {

                radioButton5.Visible = true;
                cont = Convert.ToInt16(label5.Text);
                cont++;

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

        //Salva nome e pontuação e envia proxima tela
        private void button2_Click(object sender, EventArgs e)
        {

            var form = new FrmPergunta4(label2.Text, label5.Text);
            form.Show();
            this.Visible = false;

        }
    }
}
