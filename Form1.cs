using System;
using System.CodeDom;
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
            var correctCol = Color.LimeGreen; //what color to use for correct inputs
            var incorrectCol = Color.OrangeRed; //what color to use for incorrect inputs

            //user ID full?
            if (uID == string.Empty)
            {
                txtUserID.BackColor = Color.OrangeRed;
                txtUserError.Text = "No User ID";
            } else
            {
                txtUserID.BackColor = correctCol;
                txtUserID.Enabled = false;
                txtUserError.Text = string.Empty;
                correct++;
            }

            //passcodes full
            if (pass == string.Empty)
            {
                txtPass.BackColor = incorrectCol;
                txtPasswordError.Text = "No Password";
            }
            else
            {
                correct++;
                txtPass.BackColor = correctCol;
                txtPasswordError.Text = string.Empty;
            };

            //
            if ( txtPass.BackColor == incorrectCol)
            {
                txtConfirmPass.BackColor = incorrectCol;
                txtConfirmError.Text = "No Password in main input";
            }
            else
            {
                if (pass == confirmPass )
                {
                    txtConfirmPass.BackColor = correctCol;
                    txtPass.Enabled = false;
                    txtConfirmPass.Enabled = false;
                    txtConfirmError.Text = string.Empty;
                    correct++;
                } else
                {
                    txtConfirmPass.BackColor = incorrectCol;
                    txtConfirmError.Text = "Passcodes inequal";
                };
            };
            
            // show correct var
            lblConfirmPassword.Text = correct.ToString();

        }

        private void prgStage_Click(object sender, EventArgs e)
        {

        }

        private void txtSecAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserError_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
