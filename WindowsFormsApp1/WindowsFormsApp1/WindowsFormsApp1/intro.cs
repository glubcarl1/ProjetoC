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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {
                progressBar1.Value = progressBar1.Value + 1;
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/2.wav");
                Player.Play();
            }
            catch
            {
                
                timer1.Enabled = false;
                this.Visible = false;
                FrmNome frm = new FrmNome();
                frm.ShowDialog();
 
            }

            

        }
    }
}
