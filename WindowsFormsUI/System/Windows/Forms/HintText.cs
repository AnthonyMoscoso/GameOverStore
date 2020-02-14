using System.Drawing;

namespace System.Windows.Forms
{
    internal class HintText : TextBox
    {
        public string Hint { get; set; }
        
        public HintText()
        {
            Text = Hint;
            this.LostFocus += Add_Hint;
            this.HandleCreated += Add_Hint;
            this.MouseLeave += Add_Hint;
            this.MouseClick += Vaciar_hint;
            this.KeyDown += Vaciar_hint;
        }
        
  
        private void Add_Hint(Object sender,EventArgs e )
        {

            if (Text.Equals(""))
            {
                Text = Hint;
                ForeColor = Color.Gray;
            }
        }
        private void Vaciar_hint(Object sender, EventArgs e)
        {
            if (Text.Equals(Hint))
            {
                Text = "";
                ForeColor = Color.Black;
            }

        }


    }
}