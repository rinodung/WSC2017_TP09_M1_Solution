namespace WSC2017_TP09_M1_Solution
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.cmb_office = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email Address:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(160, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(300, 20);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "abc@amonic.com";
            this.txt_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_email_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(160, 62);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(300, 20);
            this.txt_first_name.TabIndex = 5;
            this.txt_first_name.Text = "...";
            this.txt_first_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_first_name_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(160, 101);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(300, 20);
            this.txt_last_name.TabIndex = 7;
            this.txt_last_name.Text = "...";
            this.txt_last_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_last_name_Validating);
            // 
            // cmb_office
            // 
            this.cmb_office.DataSource = this.officeBindingSource;
            this.cmb_office.DisplayMember = "Title";
            this.cmb_office.FormattingEnabled = true;
            this.cmb_office.Location = new System.Drawing.Point(160, 139);
            this.cmb_office.Name = "cmb_office";
            this.cmb_office.Size = new System.Drawing.Size(300, 21);
            this.cmb_office.TabIndex = 10;
            this.cmb_office.ValueMember = "ID";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(WSC2017_TP09_M1_Solution.Office);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Offices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "BirthDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(160, 219);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(300, 20);
            this.txt_password.TabIndex = 13;
            this.txt_password.Text = "123";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Location = new System.Drawing.Point(349, 273);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 23);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_User.Location = new System.Drawing.Point(160, 273);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(128, 23);
            this.btn_Add_User.TabIndex = 15;
            this.btn_Add_User.Text = "Save";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // pickerBirthDate
            // 
            this.pickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerBirthDate.Location = new System.Drawing.Point(160, 183);
            this.pickerBirthDate.Name = "pickerBirthDate";
            this.pickerBirthDate.Size = new System.Drawing.Size(300, 20);
            this.pickerBirthDate.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 325);
            this.Controls.Add(this.pickerBirthDate);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add_User);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_office);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_email);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.ComboBox cmb_office;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.DateTimePicker pickerBirthDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}