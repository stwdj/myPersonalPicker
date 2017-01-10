using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPickerMain
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// Diese Applikation erlaubt "Type as you search"
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

            USZPersonnelPicker.PersonalPickerForm shag = new USZPersonnelPicker.PersonalPickerForm(mytitle);
            Application.Run(shag);
            
            //MessageBox.Show(shag.ReturnListOfPeople);
            Console.WriteLine(shag.ReturnListOfPeople);

        }
    }
}
