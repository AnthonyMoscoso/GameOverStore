using System.Drawing;
using System.IO;

namespace System.Windows.Forms
{
    internal class AlertPictureBox : PictureBox
    {
       
        public AlertPictureBox()
        {
           
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Drawing.Size(15, 15);
            this.Visible = false;
          
        }
        public void SetErrorMessage(string Message)
        {
            this.Visible = true;
            this.Image = Image.FromFile(Path.GetFullPath(@"_Imagenes\iconos\alert.png"));
            new ToolTip().SetToolTip(this, Message);
           
        }
        public void isCorrect()
        {
            this.Image = Image.FromFile(Path.GetFullPath(@"_Imagenes\iconos\corfirmed.png"));
            this.Visible = true;
        }
    }
}