namespace WindowsFormsUI.Ventanas._Componentes
{
    partial class FomrPaginador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnNumsPagine = new System.Windows.Forms.FlowLayoutPanel();
            this.pnNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnPrevious = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnContenedor.SuspendLayout();
            this.pnNext.SuspendLayout();
            this.pnPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContenedor
            // 
            this.pnContenedor.Controls.Add(this.pnNumsPagine);
            this.pnContenedor.Controls.Add(this.pnNext);
            this.pnContenedor.Controls.Add(this.pnPrevious);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(255, 40);
            this.pnContenedor.TabIndex = 1;
            // 
            // pnNumsPagine
            // 
            this.pnNumsPagine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNumsPagine.Location = new System.Drawing.Point(53, 5);
            this.pnNumsPagine.Name = "pnNumsPagine";
            this.pnNumsPagine.Size = new System.Drawing.Size(154, 30);
            this.pnNumsPagine.TabIndex = 2;
            // 
            // pnNext
            // 
            this.pnNext.Controls.Add(this.btnNext);
            this.pnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnNext.Location = new System.Drawing.Point(207, 5);
            this.pnNext.Name = "pnNext";
            this.pnNext.Size = new System.Drawing.Size(43, 30);
            this.pnNext.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnPrevious
            // 
            this.pnPrevious.Controls.Add(this.btnPrevious);
            this.pnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPrevious.Location = new System.Drawing.Point(5, 5);
            this.pnPrevious.Name = "pnPrevious";
            this.pnPrevious.Size = new System.Drawing.Size(48, 30);
            this.pnPrevious.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(48, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // FomrPaginador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContenedor);
            this.Name = "FomrPaginador";
            this.Size = new System.Drawing.Size(255, 40);
            this.pnContenedor.ResumeLayout(false);
            this.pnNext.ResumeLayout(false);
            this.pnPrevious.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.FlowLayoutPanel pnNumsPagine;
        private System.Windows.Forms.Panel pnNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnPrevious;
        private System.Windows.Forms.Button btnPrevious;
    }
}