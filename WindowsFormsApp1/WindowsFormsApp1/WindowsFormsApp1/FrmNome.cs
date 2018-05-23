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
    public partial class FrmNome : Form
    {
        public FrmNome()
        {
            InitializeComponent();
           
        }


        //Button é ativado e joga os dados pro outro form
        private void button1_Click(object sender, EventArgs e)
        {

            var form = new FrmPergunta1(textBox1.Text);
            form.Show();
            this.Visible = false;
           



        }

        private void FrmNome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
