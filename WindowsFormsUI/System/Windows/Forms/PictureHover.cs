﻿using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace System.Windows.Forms
{
    internal class PictureHover : PictureBox
    {
       
        public Image ImageInicial
        {
            get; set;
        }
        public bool Hover { get; set; }
        public bool Clicked { get; set; }
        public Image ImageHover{
            get;set;
            }
        public Padding MarginInt { get; set; }
        public Padding MargingOut { get; set; }
        public PictureHover()
        {


            this.ImageInicial = this.Image;
          
            this.MouseEnter += PictureHover_MouseEnter;
            this.MouseLeave += PictureHover_MouseLeave;
            this.MouseClick += PictureHover_MouseClick;
       
          
         
            this.SizeMode = PictureBoxSizeMode.Zoom;
         
 
        }

        private void PictureHover_MouseClick(object sender, MouseEventArgs e)
        {
            if (Clicked)
            {
                if (Image == ImageHover)
                {
                    Image = ImageInicial;
                }
                else
                {
                    Image = ImageHover;
                }
            }
        
        }

        public void Run()
        {
           
        }
        
        private void PictureHover_MouseLeave(object sender, EventArgs e)
        {
            if (Hover)
            {
                if (ImageInicial != null && !Clicked)
                {
                    this.Image = ImageInicial;
                   
                }
                if (MarginInt == null)
                {
                    this.Margin = new Padding(3);
                }
                else
                {
                    this.Margin = MarginInt;
                }
                
               
            }
         
            
        }

        private void PictureHover_MouseEnter(object sender, EventArgs e)
        {
           
            if (Hover)
            {
                if (ImageHover != null && !Clicked)
                {
                    this.Image = ImageHover;
                    
                }
                if (MargingOut == null)
                {
                    this.Margin = new Padding(6);
                }
                else
                {
                    this.Margin = MargingOut;
                }
                
                
            }

        }
    }
}