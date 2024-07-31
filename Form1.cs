using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

        string cmbPlaceholdText = "Select the desired question from this list"; //the placeholder combo box text

        //debug mode (one for active, anything else for inactive)
        int debugSystem = 1;

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbSecQuest.Items.Insert(0, cmbPlaceholdText);
            cmbSecQuest.SelectedIndex = 0;

            //prepare debug box
            //setup debug box
            txt_debugInfo.Text = string.Empty;
            if (debugSystem == 1)
            {
                txt_debugInfo.Show();
            };
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

            //create debug system
            string addText (string inputText) {
                if (debugSystem == 1)
                {
                    if (txt_debugInfo.Text == string.Empty)
                    {
                        txt_debugInfo.Text = inputText;
                    }
                    else
                    {
                        txt_debugInfo.AppendText(Environment.NewLine);
                        txt_debugInfo.Text += inputText;
                    }
                    
                } else
                {
                    return string.Empty;
                };
                return txt_debugInfo.Text;
            };
            
            // vars
            var correct = 0;
            var uID = txtUserID.Text; //storeID
            var pass = txtPass.Text; //pass
            var confirmPass = txtConfirmPass.Text; //passConfirm
            string secQuest = cmbSecQuest.SelectedItem.ToString(); //Security Question
            var secAns = txtSecAnswer.Text; //Security Answer
            var correctCol = Color.LimeGreen; //what color to use for correct inputs
            var incorrectCol = Color.OrangeRed; //what color to use for incorrect inputs
            var pickedSecQuest = int.Parse(lblCountSecQuest.Text);

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

            //passcodes same?
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

            correct = correct + pickedSecQuest;
            //chose question
           if (secQuest == cmbPlaceholdText)
            {
                txtQuestionWarn.Text = "Pick Desired Question";
            } else
            {
                txtQuestionWarn.Text = string.Empty;
            };

            if( secAns == string.Empty )
            {
                txtAnswerWarn.Text = "No Provided Answer";
                txtSecAnswer.BackColor = incorrectCol;
            } else
            {
                txtAnswerWarn.Text = string.Empty;
                txtSecAnswer.BackColor = correctCol;
                txtSecAnswer.Enabled = false;
                cmbSecQuest.Enabled = false;
                correct++;
            };

            addText(correct.ToString());
            addText(secQuest);

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

        private void txtAnswerWarn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionWarn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_debugInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountSecQuest_Click(object sender, EventArgs e)
        {

        }

        private void cmbSecQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //current index

            int indexNum = int.Parse(cmbSecQuest.SelectedIndex.ToString());

            //has run
            int run = int.Parse(lblCountSecQuest.Text.ToString());
            if (run == 0)
            {
                if (indexNum == 0)
                {

                }
                else
                {
                    // remove first entry
                    cmbSecQuest.Items.RemoveAt(0); 
                    lblCountSecQuest.Text = Convert.ToString(run + 1);

                };
            };
        }


    }
}
