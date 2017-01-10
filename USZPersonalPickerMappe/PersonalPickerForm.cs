using System;
using System.Text;
using System.Windows.Forms;

// Information for Github
namespace USZPersonnelPicker
{
    public partial class PersonalPickerForm : Form
    {
        public PersonalPickerForm(string title)
        {
            InitializeComponent();
            this.Text = this.Text + " - " + title;
        }

        public string ReturnListOfPeople { get; set; }
        private void PersonalPickerForm_Load(object sender, EventArgs e)
        {
            PersonalTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PersonalTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PersonalTextBox.AutoCompleteCustomSource.Clear();

            PersonalTextBox.AutoCompleteCustomSource.AddRange(System.IO.File.ReadAllLines(@"\\vm-90187\P_PDMS_PersonalPicker\USZPersonal.csv", Encoding.Default));

        }

        static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        private void PersonalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("KeyDown " + e.KeyValue.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                string takeoverName = UppercaseWords(PersonalTextBox.Text);
                //MessageBox.Show(takeoverName);
                tbSammel.AppendText(takeoverName + Environment.NewLine);
                PersonalTextBox.Clear();
                PersonalTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnListOfPeople = tbSammel.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
