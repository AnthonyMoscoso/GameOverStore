using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Eventos
{
    class ImagenControls
    {
        public static string ImageNotFound = @"_Imagenes\Iconos\imageNotFound.png";
        public static string SaveImagenIn(string ruta,string imagen,string nombre)
        {
          
            if (imagen.Trim().Length >= 0)
            {
                try
                {
                    Image guardar = Image.FromFile(imagen);
                    string imageName = nombre + "-" + Path.GetFileName(imagen);
                    guardar.Save(Path.GetFullPath(Path.Combine(ruta, imageName)));
                    guardar.Dispose();

                    return Path.GetFullPath(Path.Combine(ruta, imageName));
                }
                catch (Exception)
                {
                    return ImageNotFound;
                }
            }
            else
            {
                return ImageNotFound;
            }
        }
        public static void OpenFileDialogImage(AlertPictureBox alertImagen,PictureBox ptbxImagen,TextBox txtImagen,int maximo)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Imagenes |*.jpg;*.png;";
            open.Title = "CHOOSE IMAGE";

            if (open.ShowDialog() == DialogResult.OK)
            {


                string url_imagen = open.FileName;


                long len = (new System.IO.FileInfo(url_imagen)).Length;
                if (len > maximo)
                {
                    alertImagen.SetErrorMessage("La imagen es demasiado grande , la imagen debe pesar 250000 o menos ");

                }
                else
                {
                    alertImagen.isCorrect();
                    ptbxImagen.Load(url_imagen);
                    txtImagen.Text = url_imagen;
                    open.Dispose();

                }

            }
        }
        public static void DeleteImagen(string ruta)
        {
            
            if (ruta != ImageNotFound)
            {
                try
                {
                  
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(ruta);
                }
                catch (IOException)
                {
                  
                }
           
         
            }


        }
    }
}
