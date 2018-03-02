using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WSC2017_TP09_M1_Solution;

namespace WSC2017_TP09_M1_Solution
{
    public partial class LoginForm : Form
    {
        private int attempt = 3;
        private System.Timers.Timer aTimer;
        private int blockTime = 10;
        public LoginForm()
        {
            InitializeComponent();
            SetTimer();
        }

        private void tbn_Login_Click(object sender, EventArgs e)
        {
            
            if (attempt == 0)
            {               
                this.btn_Login.Enabled = false;
                aTimer.Start();
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
        private  void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            
        }

        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (this.lbl_Login_Result.InvokeRequired)
            {
                this.lbl_Login_Result.BeginInvoke((MethodInvoker)delegate () { this.lbl_Login_Result.Text = "All 3 apptempts have failed, please wait..." + blockTime--; });
            }
            else
            {
                this.lbl_Login_Result.Text = "All 3 apptempts have failed, please wait..." + blockTime--;
            }
           
            if(blockTime == 0)
            {
                aTimer.Stop();
                attempt = 3;
                blockTime = 10;
                if (this.btn_Login.InvokeRequired)
                {
                    this.btn_Login.BeginInvoke((MethodInvoker)delegate () { this.btn_Login.Enabled = true; });
                }
                else
                {
                    this.btn_Login.Enabled = true;
                    
                }
                if (this.lbl_Login_Result.InvokeRequired)
                {
                    this.lbl_Login_Result.BeginInvoke((MethodInvoker)delegate () {
                        this.lbl_Login_Result.Text = "";
                    });
                }
                else
                {
                    this.lbl_Login_Result.Text = "";
                }

               
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
