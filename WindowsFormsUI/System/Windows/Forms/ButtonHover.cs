namespace System.Windows.Forms
{
    internal class ButtonHover : Button
    {
        public ButtonBorderStyle ButtonBorderStyle {
            get; set; }
        public ButtonHover()
        {
            this.MouseEnter += ButtonHover_MouseEnter;
            this.MouseDown += ButtonHover_MouseDown;
            
        }

        

      
        private void ButtonHover_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void ButtonHover_MouseEnter(object sender, EventArgs e)
        {
        
        }
    }
}