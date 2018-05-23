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
    public partial class FrmPontuacao : Form
    {

        //Mostra pontos
        public FrmPontuacao(string text)
        {
            InitializeComponent();
            label5.Text = text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
