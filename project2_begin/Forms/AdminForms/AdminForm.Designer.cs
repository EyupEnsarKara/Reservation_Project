namespace project2_begin.Forms.AdminForms
{
    partial class AdminForm
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
            this.btn_viewCompany = new System.Windows.Forms.Button();
            this.btn_setServiceCost = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewCompany
            // 
            this.btn_viewCompany.BackColor = System.Drawing.Color.Azure;
            this.btn_viewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewCompany.Location = new System.Drawing.Point(74, 46);
            this.btn_viewCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_viewCompany.Name = "btn_viewCompany";
            this.btn_viewCompany.Size = new System.Drawing.Size(228, 63);
            this.btn_viewCompany.TabIndex = 1;
            this.btn_viewCompany.Text = "View Company";
            this.btn_viewCompany.UseVisualStyleBackColor = false;
            this.btn_viewCompany.Click += new System.EventHandler(this.btn_viewCompany_Click);
            // 
            // btn_setServiceCost
            // 
            this.btn_setServiceCost.BackColor = System.Drawing.Color.Azure;
            this.btn_setServiceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setServiceCost.Location = new System.Drawing.Point(74, 113);
            this.btn_setServiceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setServiceCost.Name = "btn_setServiceCost";
            this.btn_setServiceCost.Size = new System.Drawing.Size(228, 63);
            this.btn_setServiceCost.TabIndex = 2;
            this.btn_setServiceCost.Text = "Set Service Cost";
            this.btn_setServiceCost.UseVisualStyleBackColor = false;
            this.btn_setServiceCost.Click += new System.EventHandler(this.btn_setServiceCost_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(74, 181);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(228, 63);
            this.btn_mainMenu.TabIndex = 3;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(394, 292);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_setServiceCost);
            this.Controls.Add(this.btn_viewCompany);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewCompany;
        private System.Windows.Forms.Button btn_setServiceCost;
        private System.Windows.Forms.Button btn_mainMenu;
    }
}