namespace project2_begin.Forms
{
    partial class LoginForm
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
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.lbl_loginInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_username
            // 
            this.txtbox_username.BackColor = System.Drawing.Color.Azure;
            this.txtbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_username.Location = new System.Drawing.Point(84, 79);
            this.txtbox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(252, 34);
            this.txtbox_username.TabIndex = 5;
            this.txtbox_username.Text = "Username";
            this.txtbox_username.Enter += new System.EventHandler(this.txtbox_username_Enter);
            this.txtbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_username_KeyDown);
            this.txtbox_username.Leave += new System.EventHandler(this.txtbox_username_Leave);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.Azure;
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_password.Location = new System.Drawing.Point(84, 130);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(252, 34);
            this.txtbox_password.TabIndex = 6;
            this.txtbox_password.Text = "Password";
            this.txtbox_password.Enter += new System.EventHandler(this.txtbox_password_Enter);
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            this.txtbox_password.Leave += new System.EventHandler(this.txtbox_password_Leave);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(111, 181);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 22);
            this.lbl_info.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Azure;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(115, 217);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(187, 48);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.ForeColor = System.Drawing.Color.Black;
            this.btn_mainMenu.Location = new System.Drawing.Point(115, 292);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(187, 48);
            this.btn_mainMenu.TabIndex = 6;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // lbl_loginInfo
            // 
            this.lbl_loginInfo.AutoSize = true;
            this.lbl_loginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginInfo.Location = new System.Drawing.Point(126, 32);
            this.lbl_loginInfo.Name = "lbl_loginInfo";
            this.lbl_loginInfo.Size = new System.Drawing.Size(157, 29);
            this.lbl_loginInfo.TabIndex = 7;
            this.lbl_loginInfo.Text = "lbl_loginInfo";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(441, 386);
            this.Controls.Add(this.lbl_loginInfo);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Label lbl_loginInfo;
    }
}