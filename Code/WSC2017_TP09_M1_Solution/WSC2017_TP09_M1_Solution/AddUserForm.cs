using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2017_TP09_M1_Solution;

namespace WSC2017_TP09_M1_Solution
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            session1Entities db = new session1Entities();
            db.Offices.Load();
            this.officeBindingSource.DataSource = db.Offices.Local.ToBindingList();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            session1Entities db = new session1Entities();
            User newUser = new User();
            newUser.ID = db.Users.Max(u => u.ID) + 1;

            newUser.Email = this.txt_email.Text;
            User existedEmail = db.Users.FirstOrDefault(p => p.Email == this.txt_email.Text);
            if(existedEmail != null)
            {
                MessageBox.Show("Existed Email Address");
                return;
            }

            newUser.FirstName = this.txt_first_name.Text;
            newUser.LastName = this.txt_last_name.Text;
            if(this.pickerBirthDate.Text != "" )
            {
                newUser.Birthdate = DateTime.Parse(pickerBirthDate.Text);
            }
            
            newUser.Password = this.txt_password.Text;
            newUser.Active = true;
            newUser.RoleID = 2;//default User Role =2
            db.Users.Add(newUser);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Create user successfully");
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);
                MessageBox.Show(fullErrorMessage);                

            }

          
            
        }


        private void txt_last_name_Validating(object sender, CancelEventArgs e)
        {
            if(this.txt_last_name.Text == "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.txt_last_name, "Empty Value");
            }
        }
      

        private void txt_first_name_Validating(object sender, CancelEventArgs e)
        {
            if (this.txt_first_name.Text == "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.txt_first_name, "Empty value");
            }
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (this.txt_email.Text.Length == 0)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.txt_email, "Empty value");
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (this.txt_email.Text.IndexOf("@") == -1)
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.txt_email, "Invalid Email");
            }

        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (this.txt_password.Text == "")
            {
                e.Cancel = true;
                this.errorProvider.SetError(this.txt_password, "Empty Value");
            }
        }
    }
}
