using System;
using System.Text;
using System.Windows.Forms;

namespace USZPersonnelPickerCOM
{
    public partial class PersonalPickerForm : Form
    {
        public PersonalPickerForm()
        {
            InitializeComponent();
        }

        private void PersonalPickerForm_Load(object sender, EventArgs e)
        {
            PersonalTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PersonalTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PersonalTextBox.AutoCompleteCustomSource.Clear();

            PersonalTextBox.AutoCompleteCustomSource.AddRange(System.IO.File.ReadAllLines(@"\\vm-90187\P_PDMS_PersonalPicker\USZPersonal.csv", Encoding.Default));


        }


        private void PersonalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("KeyDown " + e.KeyValue.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                tbSammel.AppendText(PersonalTextBox.Text + "* ");
                PersonalTextBox.Clear();
                PersonalTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
