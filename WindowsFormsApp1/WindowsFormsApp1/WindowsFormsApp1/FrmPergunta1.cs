using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FrmPergunta1 : Form
    {

        //Var adicionar ponto
        int contador = 0;

        //Recebe nome do user
        public FrmPergunta1(string nome)
        {
            InitializeComponent();
            label2.Text = nome;

        }

       

        //Button, adiciona ponto caso acerte, mostra a opção correta.
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                radioButton5.Visible = true;
                contador++;
                
            }
            if (radioButton2.Checked)
            {
                radioButton5.Visible = true;
               
            }
            if (radioButton3.Checked)
            {
                radioButton5.Visible = true;
                
            }
            if (radioButton4.Checked)
            {

                radioButton5.Visible = true;
               


            }

            label5.Text = Convert.ToString(contador);

                button1.Visible = false;
                button2.Visible = true;
            


        }

        //Guarda Nick e Ponto do usuario e manda para proxima tela
        private void Btn2_Click(object sender, EventArgs e)
        {

                var form = new FrmPergunta2(label2.Text, label5.Text);
                form.Show();
                this.Visible = false;


            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

