namespace Stock
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chB_showPassword = new System.Windows.Forms.CheckBox();
            this.lbl_error_message = new System.Windows.Forms.Label();
            this.lklb_to_login = new System.Windows.Forms.LinkLabel();
            this.btn_register = new System.Windows.Forms.Button();
            this.cBox_role = new System.Windows.Forms.ComboBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB_names = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chB_showPassword);
            this.groupBox1.Controls.Add(this.lbl_error_message);
            this.groupBox1.Controls.Add(this.lklb_to_login);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.cBox_role);
            this.groupBox1.Controls.Add(this.txtB_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtB_names);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtB_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(-6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 623);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up Form";
            // 
            // chB_showPassword
            // 
            this.chB_showPassword.AutoSize = true;
            this.chB_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chB_showPassword.Location = new System.Drawing.Point(625, 267);
            this.chB_showPassword.Name = "chB_showPassword";
            this.chB_showPassword.Size = new System.Drawing.Size(148, 24);
            this.chB_showPassword.TabIndex = 6;
            this.chB_showPassword.Text = "Show Password";
            this.chB_showPassword.UseVisualStyleBackColor = true;
            this.chB_showPassword.CheckedChanged += new System.EventHandler(this.chB_showPassword_CheckedChanged_1);
            // 
            // lbl_error_message
            // 
            this.lbl_error_message.AutoSize = true;
            this.lbl_error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_message.Location = new System.Drawing.Point(319, 466);
            this.lbl_error_message.Name = "lbl_error_message";
            this.lbl_error_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_error_message.TabIndex = 5;
            // 
            // lklb_to_login
            // 
            this.lklb_to_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lklb_to_login.AutoSize = true;
            this.lklb_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklb_to_login.Location = new System.Drawing.Point(429, 409);
            this.lklb_to_login.Name = "lklb_to_login";
            this.lklb_to_login.Size = new System.Drawing.Size(163, 20);
            this.lklb_to_login.TabIndex = 4;
            this.lklb_to_login.TabStop = true;
            this.lklb_to_login.Text = "Have account ? Login";
            this.lklb_to_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_to_login_LinkClicked_1);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(323, 329);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(409, 61);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cBox_role
            // 
            this.cBox_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBox_role.FormattingEnabled = true;
            this.cBox_role.Items.AddRange(new object[] {
            "Admin",
            "Sales",
            "Manager",
            "Storekeeper"});
            this.cBox_role.Location = new System.Drawing.Point(54, 215);
            this.cBox_role.Name = "cBox_role";
            this.cBox_role.Size = new System.Drawing.Size(383, 37);
            this.cBox_role.TabIndex = 2;
            // 
            // txtB_password
            // 
            this.txtB_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_password.Location = new System.Drawing.Point(625, 195);
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.Size = new System.Drawing.Size(383, 39);
            this.txtB_password.TabIndex = 1;
            this.txtB_password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // txtB_names
            // 
            this.txtB_names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtB_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_names.Location = new System.Drawing.Point(625, 87);
            this.txtB_names.Name = "txtB_names";
            this.txtB_names.Size = new System.Drawing.Size(383, 39);
            this.txtB_names.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Names";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Role";
            // 
            // txtB_email
            // 
            this.txtB_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtB_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_email.Location = new System.Drawing.Point(54, 87);
            this.txtB_email.Name = "txtB_email";
            this.txtB_email.Size = new System.Drawing.Size(383, 39);
            this.txtB_email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 634);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chB_showPassword;
        private System.Windows.Forms.Label lbl_error_message;
        private System.Windows.Forms.LinkLabel lklb_to_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox cBox_role;
        private System.Windows.Forms.TextBox txtB_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB_names;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_email;
        private System.Windows.Forms.Label label3;
    }
}

