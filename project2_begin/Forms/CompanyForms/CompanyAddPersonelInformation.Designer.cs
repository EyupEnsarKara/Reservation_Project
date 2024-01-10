namespace project2_begin.Forms.CompanyForms
{
    partial class CompanyAddPersonelInformation
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_firstName = new System.Windows.Forms.TextBox();
            this.txtbox_lastName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_vehicleMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(112, 34);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(262, 29);
            this.lbl_info.TabIndex = 25;
            this.lbl_info.Text = ".Personel Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Firstname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lastname :";
            // 
            // comboBox_role
            // 
            this.comboBox_role.BackColor = System.Drawing.Color.Azure;
            this.comboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Driver",
            "Helper"});
            this.comboBox_role.Location = new System.Drawing.Point(191, 210);
            this.comboBox_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(160, 37);
            this.comboBox_role.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Role :";
            // 
            // txtbox_firstName
            // 
            this.txtbox_firstName.BackColor = System.Drawing.Color.Azure;
            this.txtbox_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_firstName.Location = new System.Drawing.Point(191, 97);
            this.txtbox_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_firstName.Name = "txtbox_firstName";
            this.txtbox_firstName.Size = new System.Drawing.Size(160, 34);
            this.txtbox_firstName.TabIndex = 30;
            // 
            // txtbox_lastName
            // 
            this.txtbox_lastName.BackColor = System.Drawing.Color.Azure;
            this.txtbox_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_lastName.Location = new System.Drawing.Point(191, 155);
            this.txtbox_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_lastName.Name = "txtbox_lastName";
            this.txtbox_lastName.Size = new System.Drawing.Size(160, 34);
            this.txtbox_lastName.TabIndex = 31;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Azure;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(191, 273);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(160, 50);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_vehicleMenu
            // 
            this.btn_vehicleMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_vehicleMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicleMenu.Location = new System.Drawing.Point(144, 329);
            this.btn_vehicleMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_vehicleMenu.Name = "btn_vehicleMenu";
            this.btn_vehicleMenu.Size = new System.Drawing.Size(268, 50);
            this.btn_vehicleMenu.TabIndex = 33;
            this.btn_vehicleMenu.Text = "Vehicle Menu";
            this.btn_vehicleMenu.UseVisualStyleBackColor = false;
            this.btn_vehicleMenu.Visible = false;
            this.btn_vehicleMenu.Click += new System.EventHandler(this.btn_vehicleMenu_Click);
            // 
            // CompanyAddPersonelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(448, 400);
            this.Controls.Add(this.btn_vehicleMenu);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtbox_lastName);
            this.Controls.Add(this.txtbox_firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompanyAddPersonelInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyAddPersonelInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_firstName;
        private System.Windows.Forms.TextBox txtbox_lastName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_vehicleMenu;
    }
}