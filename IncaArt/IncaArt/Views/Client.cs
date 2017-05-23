using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Client : UserControl
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = this.textBoxDNI.Text;
            string name = this.textBoxName.Text;
            string paternal_last_name = this.textBoxPaternalLastName.Text;
            string maternal_last_name = this.textBoxMaternalLastName.Text;
            string phone = this.textBoxPhone.Text;
            string email = this.textBoxEmail.Text;
            char gender = 'M';
            string address = this.textBoxAddress.Text;
            DateTime birthday = this.dateTimePickerBirthdate.Value;

            if (this.radioButtonMale.Checked)
            {
                gender = 'M';
            } else if (this.radioButtonFemale.Checked)
            {
                gender = 'F';
            }

            Person person = new Person(0, dni, name, paternal_last_name, maternal_last_name, phone, email, gender, address, birthday);

        }
    }
}
