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
    public partial class Form1 : Form
    {
        DatabaseDataContext db_dc;
        public Form1()
        {
            InitializeComponent();
            Text = "Baza Danych";
            db_dc = new DatabaseDataContext();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            RefreshList();

            //foreach (Person p in db_dc.Persons.Where(x=>x.Height>180))
            //foreach (Person p in db_dc.Persons.OrderBy(x=>x.Name))

            /*List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            List<int> l2 = l.Where(x => x % 2 == 0)
                            .OrderByDescending(x=>x)
                            .ToList();   //dobry przykład użyteczności LINQ poza bazami danych
            foreach (int lx in l2)
            {
                Text += lx;
            }
            int i;
            i=l2.Count;     //właściwość listy
            i==l2.Count();  //metoda LINQ
             
             */

        }

        private void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (Person p in db_dc.Persons)
            {
                listBox1.Items.Add(p);  //albo tutaj p.name albo w designerze listbox DisplayMember name
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                if(listBox1.SelectedItem is Person)
                {
                    Person p = listBox1.SelectedItem as Person;
                    db_dc.Persons.DeleteOnSubmit(p);
                    db_dc.SubmitChanges();
                    RefreshList();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Adding formAdd = new Adding();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                db_dc.Persons.InsertOnSubmit(formAdd.Person);
                db_dc.SubmitChanges();
                RefreshList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem is Person)
                {
                    Person p = listBox1.SelectedItem as Person;

                    Adding formEdit = new Adding(p);
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        db_dc.SubmitChanges();
                        RefreshList();
                    }

                    RefreshList();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == null)
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        /*
CREATE TABLE [dbo].[Person]
(
[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
[Name] VARCHAR(50) NOT NULL, 
[BirthDate] DATE NOT NULL, 
[Height] INT NOT NULL
)
*/
    }
}
