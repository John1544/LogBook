using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook.WinForms
{
    public partial class MillerLogBookForm : Form
    {
        Person personModel = new Person();
        PersonService personService = new PersonService();
        public MillerLogBookForm()
        {
            InitializeComponent();
        }

/*        private void BtnSave_Click(object sender, EventArgs e)
        {
            personModel.FirstName = TxtFirstName.Text;
            personModel.LastName = TxtLastName.Text;
            try
            {
                personService.PostPerson(personModel);
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("First Name is Taken", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearText();
            LoadPersons();
            BtnCancel.Enabled = true;
        }*/

        private void MillerLogBookForm_Load(object sender, EventArgs e)
        {
/*            ClearText();
            LoadPersons();*/
        }

/*        private void ClearText()
        {
            TxtFirstName.Text = TxtLastName.Text = TxtLastName.Text = TxtLastName.Text = string.Empty;
            BtnSave.Text = "Save";
        }

        private void LoadPersons()
        {
            DataGridViewPersons.AutoGenerateColumns = false;
            DataGridViewPersons.DataSource = null;
            DataGridViewPersons.DataSource = personService.GetAll();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "To Delete the record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }*/
    }
}
