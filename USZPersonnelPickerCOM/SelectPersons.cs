using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USZPersonnelPickerCOM
{
    public class SelectPersons
    {
        public string SayHi(string name)
        {
            return string.Format("Hi {0}", name);
        }
        public string SelectPerson(string Title)
        {
            PersonalPickerForm ppf = new PersonalPickerForm("Anästhesie");

            return "Done";
        }
       
    }
}
