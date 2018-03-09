using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2017_TP09_M1_Solution
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            session1Entities db = new session1Entities();
            db.Users.Load();
            this.userBindingSource.DataSource = db.Users.Local.ToBindingList();
            db.Offices.Load();
            this.officeBindingSource.DataSource = db.Offices.Local.ToBindingList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();            
        }

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRoleForm editRoleForm = new EditRoleForm();
            editRoleForm.Show();
        }
    }
}
