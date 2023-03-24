using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanych
{
    public partial class Adding : Form
    {
        Person newPerson;

        public Person Person
        {
            get => newPerson;
        }
        public Adding()
        {
            InitializeComponent();
            newPerson = new Person();
            Text = "Dodawanie";
            ValidatePerson();
        }

        public Adding(Person p)
        {
            InitializeComponent();
            newPerson = p;
            Text = "Edycja";

            newName.Text = newPerson.Name;
            newDate.Value = newPerson.BirthDate;
            newHeight.Value = newPerson.Height;
            ValidatePerson();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void ValidatePerson()
        {
            if (newName.TextLength > 3 && newDate.Value <= DateTime.Today)
            {
                buttonConfirm.Enabled = true;
            }
            else
            {
                buttonConfirm.Enabled = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            newPerson.Name = newName.Text;
            newPerson.BirthDate = newDate.Value;
            newPerson.Height = (int)newHeight.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
