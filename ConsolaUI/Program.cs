using Entitidades.Concretas;
using Negocios.Abstractas;
using Negocios.Abstractas.Simples;
using Negocios.Concretas;
using Negocios.ResolverDependencias.Ninject;
using Ninject;
using Nucleo.Utilidades.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI;

namespace ConsolaUI
{
    class Program
    {

        [STAThread]
        static void Main()
        {

            CompositionRoot.Wire(new ModuloNinject());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
