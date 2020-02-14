using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas._Componentes
{
    public partial class PassWordTxt : UserControl
    {
        bool CanSeePass;
        public PassWordTxt()
        {
            InitializeComponent();
            txtPassword.TextChanged += TxtPassword_TextChanged;
            CanSeePass = false;

        }
        public string GetPassWord()
        {
            return txtPassword.Text;
        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            string text = txtPassword.Text;
            if (!text.Equals(txtPassword.Hint) && !CanSeePass)
            {
                txtPassword.PasswordChar = '*';
            }
            if (text.Length > 0 && !text.Equals(txtPassword.Hint)){
                pnEye.Visible = true;
            }
            else
            {
                pnEye.Visible = false;
            }
        }

        private void ImageSee_Click(object sender, EventArgs e)
        {
            if (!CanSeePass)
            {
                CanSeePass = true;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                CanSeePass = false;
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
