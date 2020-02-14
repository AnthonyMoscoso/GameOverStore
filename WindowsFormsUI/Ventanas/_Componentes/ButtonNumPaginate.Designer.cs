namespace WindowsFormsUI.Ventanas._Componentes
{
    partial class ButtonNumPaginate
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnNum = new System.Windows.Forms.Panel();
            this.lbNum = new System.Windows.Forms.Label();
            this.pnNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNum
            // 
            this.pnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNum.Controls.Add(this.lbNum);
            this.pnNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNum.Location = new System.Drawing.Point(4, 4);
            this.pnNum.Name = "pnNum";
            this.pnNum.Size = new System.Drawing.Size(26, 25);
            this.pnNum.TabIndex = 0;
            // 
            // lbNum
            // 
            this.lbNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNum.Location = new System.Drawing.Point(0, 0);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(24, 23);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "1";
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonNumPaginate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.pnNum);
            this.Name = "ButtonNumPaginate";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(34, 33);
            this.pnNum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNum;
        private System.Windows.Forms.Label lbNum;
    }
}
