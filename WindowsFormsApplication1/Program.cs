using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {


            //Befehlszeilenargumente auslesen

            string[] CommandLineArgs = Environment.GetCommandLineArgs();
            string mytitle = "";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (CommandLineArgs.Count() > 1) 
            {
                mytitle = CommandLineArgs[1].ToString();
            } else
            {
                mytitle = "Test";
            }

            USZPersonnelPickerCOM.PersonalPickerForm shag = new USZPersonnelPickerCOM.PersonalPickerForm(mytitle);
            Application.Run(shag);

            //MessageBox.Show(shag.ReturnListOfPeople);
            Console.WriteLine(shag.ReturnListOfPeople);

        }
    }
}
