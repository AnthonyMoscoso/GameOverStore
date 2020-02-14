using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;

namespace WindowsFormsUI.Ventanas._Componentes
{
    public partial class DataBox : UserControl
    {
        public enum TipeText
        {
            All, ONLY_NUMBERS, ONLY_LETTERS
        }
        public bool IsPassword { get; set; }
        public string Titule { get; set; }
        public string TextoHint { get; set; }
        
        public string Texto
        {
            get
            {
                return txtData.Text;
            }
            set
            {
                txtData.Text=value;
            }
        }
        public Image Imagen { get; set; }
        public void SetErrorMessage(string error)
        {
            alertData.SetErrorMessage(error);
        }
        public void SetCorrect()
        {
            alertData.isCorrect();
        }
      
        public TipeText Tipo_De_Texto { get; set; }

        public DataBox()
        {
            InitializeComponent();
            txtData.TextChanged += TxtData_TextChanged;
            this.Load += DataBox_Load;
        }

       private void TxtData_TextChanged(object sender, EventArgs e)
        {
            if (txtData.Text.Equals(txtData.Hint) && IsPassword)
            {
                txtData.PasswordChar = '\0';
            }
        }

        public void TipeData()
        {
            if (Tipo_De_Texto == TipeText.ONLY_LETTERS)
            {
                txtData.Tipo_De_Texto = HintText.TipeText.ONLY_LETTERS;

            }
            else if (Tipo_De_Texto == TipeText.ONLY_NUMBERS)
            {
                txtData.Tipo_De_Texto = HintText.TipeText.ONLY_NUMBERS;

            }
            else
            {
                txtData.Tipo_De_Texto = HintText.TipeText.All;
            }
            this.Load += DataBox_Load;
        }

        private void DataBox_Load(object sender, EventArgs e)
        {
            if (Titule != null)
            {
                lbNombreData.Text = Titule;
            }
            if (TextoHint != null)
            {
                txtData.Hint = TextoHint;
            }
            if (Imagen != null)
            {
                ptbxImagenData.Image = Imagen;
            }
            if (Texto != null)
            {
                txtData.Text = Texto;
            }
            if (IsPassword)
            {
                EyeImage.Visible = true;
                txtData.PasswordChar = '*';
            }
            TipeData();
        }

    

        private void EyeImage_Click(object sender, EventArgs e)
        {
            if (txtData.PasswordChar.Equals('*'))
            {
                txtData.PasswordChar = '\0';
            }
            else
            {
                txtData.PasswordChar = '*';
            }
        }
    }
}
