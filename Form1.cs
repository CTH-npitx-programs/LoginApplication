using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        //close program
        private void btnClose_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_UserID_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var correct = 0;
            var uID = txtUserID.Text; //storeID
            var pass = txtPass.Text; //pass
            var confirmPass = txtConfirmPass.Text; //passConfirm
            var secQuest = cmbSecQuest.Text; //Security Question
            var secAns = txtSecAnswer.Text; //Security Answer

            //user ID full?
            if (uID == string.Empty)
            {
                txtUserID.BackColor = Color.OrangeRed;
                
            } else
            {
                txtUserID.BackColor = Color.LimeGreen;
                txtUserID.Enabled = false;
                correct = 1;
            }

            //passcodes full and equal? (first is for full)
            if (pass == string.Empty)
            {
                txtPass.BackColor = Color.OrangeRed;
                txtConfirmPass.BackColor = Color.OrangeRed;
            }
            else
            {
                txtPass.BackColor = Color.LimeGreen;
                //passcode 2 full?
                if (confirmPass == string.Empty)
                {
                    txtConfirmPass.BackColor = Color.OrangeRed;
                }
                else
                {
                    txtPass.BackColor = Color.White;

                    //passcodes same?
                    if (confirmPass == pass)
                    {
                        txtConfirmPass.BackColor = Color.LimeGreen;
                        txtPass.BackColor = Color.LimeGreen;
                        txtConfirmPass.Enabled = false;
                        txtPass.Enabled = false;
                        correct++;
                    }
                    else
                    {
                        txtConfirmPass.BackColor = Color.OrangeRed;
                    };
                }
            };
       
        }

        private void prgStage_Click(object sender, EventArgs e)
        {

        }

        private void txtSecAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
