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
        private int last_id;
        private List<Models.Client> client_list;
        private List<Company> company_list;

        public Client()
        {
            InitializeComponent();
        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name, String dni, DateTime birthday, char gender, String address, String phone, String email, string companyName)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del trabajador.\n";
            }
            if (paternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido paterno del trabajador.\n";
            }
            if (maternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido materno del trabajador.\n";
            }
            if (dni == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el dni del trabajador.\n";
            }
            if (gender == ' ')
            {
                isCorrect = false;
                message += "- Debe ingresar el género del trabajador.\n";
            }
            if (address == "")
            {
                isCorrect = false;
                message += "- Debe ingresar la dirección del trabajador.\n";
            }
            if (phone == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el teléfono del trabajador.\n";
            }
            if (email == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el email del trabajador.\n";
            }
            if (companyName == "")
            {
                isCorrect = false;
                message += "- Debe ingresar una compania.\n";
            }

            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar trabajador", MessageBoxButtons.OK);
            }

            return isCorrect;
        }

        private Company findCompanyByName(string name)
        {
            foreach (Company c in company_list)
            {
                if(c.Name == name)
                {
                    return c;
                }
            }

            return company_list[0];
        }

        private void Load_DataGridView(String name, String paternal, String maternal, String email)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < client_list.Count(); i++)
            {
                if ((name == "" || name.ToUpper() == client_list[i].Person.Name.ToUpper()) && (paternal == "" || paternal.ToUpper() == client_list[i].Person.Paternal_last_name.ToUpper()) &&
                    (maternal == "" || maternal.ToUpper() == client_list[i].Person.Maternal_last_name.ToUpper()) && (email == "" || email == client_list[i].Person.Dni) && client_list[i].Status == 1)
                {
                    String[] row = new String[5];
                    row[0] = client_list[i].Person.Name;
                    row[1] = client_list[i].Person.Paternal_last_name;
                    row[2] = client_list[i].Person.Maternal_last_name;
                    row[3] = client_list[i].Person.Email;
                    this.dataGridView1.Rows.Add(row);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = this.textBoxDNI.Text;
            string name = this.textBoxName.Text;
            string paternal_last_name = this.textBoxPaternalLastName.Text;
            string maternal_last_name = this.textBoxMaternalLastName.Text;
            string phone = this.textBoxPhone.Text;
            string email = this.textBoxEmail.Text;
            char gender = ' ';
            string address = this.textBoxAddress.Text;
            DateTime birthday = this.dateTimePickerBirthdate.Value;
            string companyName = this.comboBoxCompany.Text;

            if (this.radioButtonMale.Checked)
            {
                gender = 'M';
            } else if (this.radioButtonFemale.Checked)
            {
                gender = 'F';
            }

            if (validate_data(name, paternal_last_name, maternal_last_name, dni, birthday, gender, address, phone, email, companyName))
            {
                Company company = findCompanyByName(companyName);
                Person person = new Person(++last_id, dni, name, paternal_last_name, maternal_last_name, phone, email, gender, address, birthday);

                Models.Client client = new Models.Client(last_id, person, 1, company);
                client_list.Add(client);
                Load_DataGridView("", "", "", "");
                Clean();
            }

        }

        private void Clean()
        {
            this.textBoxDNI.Text = "";
            this.textBoxName.Text = "";
            this.textBoxPaternalLastName.Text = "";
            this.textBoxMaternalLastName.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxEmail.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            this.textBoxAddress.Text = "";
            dateTimePickerBirthdate.Text = "";
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client_list = new List<Models.Client>();
            company_list = new List<Company>();
            last_id = client_list.Count();

            Company company1 = new Company(1, "Compañia 1");
            Company company2 = new Company(1, "Compañia 2");
            Company company3 = new Company(1, "Compañia 3");

            company_list.Add(company1);
            company_list.Add(company2);
            company_list.Add(company3);

            Person person = new Person(++last_id, "12345678", "Juan", "Perez", "Hoyos", "999988899", "juan.perez@pucp.pe", 'M', "Av. Prueba 123", new DateTime(1989, 5, 12));
            Models.Client client = new Models.Client(last_id, person, 1, company_list[0]);
            
            client_list.Add(client);

            foreach (var item in company_list)
            {
                comboBoxCompany.Items.Add(item.Name);
            }

            Load_DataGridView("", "", "", "");
        }
    }
}
