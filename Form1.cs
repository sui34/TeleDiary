using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleDiary
{
    public partial class PhoneDiary : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;

        public PhoneDiary()
        {
            InitializeComponent();
        }

        private void contactDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumberTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            firstNameTxtBox.Text = "";
            lastNameTxtBox.Text = "";
            phoneNumberTxtBox.Text = "";
            emailTxtBox.Text = "";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            /***
             contactDataGridView.CurrentCell.RowIndex
             : Fetching the RowIndex of CurrentCell from contactDataGridView 
            ***/
            firstNameTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumberTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTxtBox.Text = contacts.Rows[contactDataGridView.CurrentCell.RowIndex].ItemArray[3].ToString();

            //for editing
            editing = true;

        }

        private void PhoneDiary_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone Number");
            contacts.Columns.Add("Email");

            //Set Data Source
            contactDataGridView.DataSource = contacts;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactDataGridView.CurrentCell.RowIndex]["First Name"] = firstNameTxtBox.Text;
                contacts.Rows[contactDataGridView.CurrentCell.RowIndex]["Last Name"] = lastNameTxtBox.Text;
                contacts.Rows[contactDataGridView.CurrentCell.RowIndex]["Phone Number"] = phoneNumberTxtBox.Text;
                contacts.Rows[contactDataGridView.CurrentCell.RowIndex]["Email"] = emailTxtBox.Text;
            }
            else
            {
                contacts.Rows.Add(firstNameTxtBox.Text,lastNameTxtBox.Text, phoneNumberTxtBox.Text, emailTxtBox.Text);
            }

            //clear all the field after saving
            firstNameTxtBox.Text = "";
            lastNameTxtBox.Text = "";
            phoneNumberTxtBox.Text = "";
            emailTxtBox.Text = "";
            editing = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactDataGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception)
            {

                Console.WriteLine("Not a valid row.");
            }
        }

        private void contactDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void firstNameLbl_Click(object sender, EventArgs e)
        {

        }
        private void firstNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
