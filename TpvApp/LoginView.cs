using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpvApp
{
    public partial class FormLogin : Form
    {
        String passwd;
        bool admin;

        Tpvform_init fm = null;

        public FormLogin()
        {
            InitializeComponent();
            passwd = "root";

            fm = new Tpvform_init();

        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPasswd.Text.ToString().Equals(passwd.ToUpper()))
            {
                MessageBox.Show("Contraseña correcta!");
                              
                admin = true;
                fm.checkAdmin(admin);
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Incorrecto!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button1.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button2.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button3.Text.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button4.Text.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button5.Text.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button6.Text.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button7.Text.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button8.Text.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button9.Text.ToString());
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button0.Text.ToString());
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonQ.Text.ToString());
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonW.Text.ToString());
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonE.Text.ToString());
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonR.Text.ToString());
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonT.Text.ToString());
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonY.Text.ToString());
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonU.Text.ToString());
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonI.Text.ToString());
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonO.Text.ToString());
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonP.Text.ToString());
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonA.Text.ToString());
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonS.Text.ToString());
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonD.Text.ToString());
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonF.Text.ToString());
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonG.Text.ToString());
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonH.Text.ToString());
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonJ.Text.ToString());
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonK.Text.ToString());
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonL.Text.ToString());
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonÑ.Text.ToString());
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonZ.Text.ToString());
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonX.Text.ToString());
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonC.Text.ToString());
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonV.Text.ToString());
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonB.Text.ToString());
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonN.Text.ToString());
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(buttonM.Text.ToString());
        }

        private void button_punto_Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button_punto.Text.ToString());
        }

        private void button__Click(object sender, EventArgs e)
        {
            textBoxPasswd.AppendText(button_.Text.ToString());
        }

        private void buttonBackArrow_Click(object sender, EventArgs e)
        {
            textBoxPasswd.Text = "";
        }

        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm.Show();
        }
    }
}
