using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2017_TP09_M1_Solution;

namespace WSC2017_TP09_M1_Solution
{
    public partial class LoginForm : Form
    {
        private int attempt = 3;
        public LoginForm()
        {
            InitializeComponent();           
        }

        private void tbn_Login_Click(object sender, EventArgs e)
        {
            
            if (attempt == 0)
            {
                this.lbl_Login_Result.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");                
                return;
            }
            using (session1Entities db = new session1Entities())
            {
                string username = this.txt_username.Text;
                string password = this.txt_username.Text;
                User user = db.Users.FirstOrDefault(p => p.Email == username && p.Password == password);
                if (user == null) { 
             
                    this.lbl_Login_Result.Text = "Invalid user name or password.";
                    this.txt_username.Focus();
                    attempt--;
                } else if (user.RoleID == 1)
                {
                    AdministratorForm adminForm = new AdministratorForm();
                    adminForm.ShowDialog();
                }
                else if (user.RoleID == 2)
                {

                    UserForm userForm = new UserForm();
                    userForm.ShowDialog();
                }
                
            } ;
           
        }
        private int ValidateUser(string username, string password)
        {
            
            int result = 0;           

            SqlConnection conn = new SqlConnection("Data Source=admin/SQLEXPRESS;Initial Catalog=session1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("Select @count=Count(*) from [dbo].[Users] where username=@username and password=@password", conn);
            cmd.Parameters.AddWithValue("@email", this.txt_username.Text);
            cmd.Parameters.AddWithValue("@password", this.txt_password.Text);
            cmd.Parameters.Add("@count", SqlDbType.Int).Direction = ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();
            if (Convert.ToInt32(cmd.Parameters["@count"].Value) > 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            conn.Close();
            return result;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
