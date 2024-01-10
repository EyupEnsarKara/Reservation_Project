namespace project2_begin.Forms.CompanyForms
{
    partial class CompanyForm
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.btn_vehicleSettings = new System.Windows.Forms.Button();
            this.btn_tripSettings = new System.Windows.Forms.Button();
            this.btn_setSalaries = new System.Windows.Forms.Button();
            this.btn_setFuelCosts = new System.Windows.Forms.Button();
            this.btn_calculateDailyProfit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(116, 54);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(212, 29);
            this.lbl_welcome.TabIndex = 5;
            this.lbl_welcome.Text = "Company Name: ";
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.Location = new System.Drawing.Point(131, 377);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(247, 50);
            this.btn_mainmenu.TabIndex = 13;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // btn_vehicleSettings
            // 
            this.btn_vehicleSettings.BackColor = System.Drawing.Color.Azure;
            this.btn_vehicleSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicleSettings.Location = new System.Drawing.Point(93, 107);
            this.btn_vehicleSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_vehicleSettings.Name = "btn_vehicleSettings";
            this.btn_vehicleSettings.Size = new System.Drawing.Size(329, 50);
            this.btn_vehicleSettings.TabIndex = 14;
            this.btn_vehicleSettings.Text = "Vehicle Settings";
            this.btn_vehicleSettings.UseVisualStyleBackColor = false;
            this.btn_vehicleSettings.Click += new System.EventHandler(this.btn_vehicleSettings_Click);
            // 
            // btn_tripSettings
            // 
            this.btn_tripSettings.BackColor = System.Drawing.Color.Azure;
            this.btn_tripSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tripSettings.Location = new System.Drawing.Point(93, 161);
            this.btn_tripSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tripSettings.Name = "btn_tripSettings";
            this.btn_tripSettings.Size = new System.Drawing.Size(329, 50);
            this.btn_tripSettings.TabIndex = 15;
            this.btn_tripSettings.Text = "Trip Settings";
            this.btn_tripSettings.UseVisualStyleBackColor = false;
            this.btn_tripSettings.Click += new System.EventHandler(this.btn_tripSettings_Click);
            // 
            // btn_setSalaries
            // 
            this.btn_setSalaries.BackColor = System.Drawing.Color.Azure;
            this.btn_setSalaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setSalaries.Location = new System.Drawing.Point(93, 215);
            this.btn_setSalaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setSalaries.Name = "btn_setSalaries";
            this.btn_setSalaries.Size = new System.Drawing.Size(329, 50);
            this.btn_setSalaries.TabIndex = 16;
            this.btn_setSalaries.Text = "Set Salaries";
            this.btn_setSalaries.UseVisualStyleBackColor = false;
            this.btn_setSalaries.Click += new System.EventHandler(this.btn_setSalaries_Click);
            // 
            // btn_setFuelCosts
            // 
            this.btn_setFuelCosts.BackColor = System.Drawing.Color.Azure;
            this.btn_setFuelCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setFuelCosts.Location = new System.Drawing.Point(93, 269);
            this.btn_setFuelCosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setFuelCosts.Name = "btn_setFuelCosts";
            this.btn_setFuelCosts.Size = new System.Drawing.Size(329, 50);
            this.btn_setFuelCosts.TabIndex = 17;
            this.btn_setFuelCosts.Text = "Set Fuel Costs";
            this.btn_setFuelCosts.UseVisualStyleBackColor = false;
            this.btn_setFuelCosts.Click += new System.EventHandler(this.btn_setFuelCosts_Click);
            // 
            // btn_calculateDailyProfit
            // 
            this.btn_calculateDailyProfit.BackColor = System.Drawing.Color.Azure;
            this.btn_calculateDailyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateDailyProfit.Location = new System.Drawing.Point(93, 323);
            this.btn_calculateDailyProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calculateDailyProfit.Name = "btn_calculateDailyProfit";
            this.btn_calculateDailyProfit.Size = new System.Drawing.Size(329, 50);
            this.btn_calculateDailyProfit.TabIndex = 18;
            this.btn_calculateDailyProfit.Text = "Calculate Daily Profit";
            this.btn_calculateDailyProfit.UseVisualStyleBackColor = false;
            this.btn_calculateDailyProfit.Click += new System.EventHandler(this.btn_calculateDailyProfit_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(518, 468);
            this.Controls.Add(this.btn_calculateDailyProfit);
            this.Controls.Add(this.btn_setFuelCosts);
            this.Controls.Add(this.btn_setSalaries);
            this.Controls.Add(this.btn_tripSettings);
            this.Controls.Add(this.btn_vehicleSettings);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.lbl_welcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Button btn_vehicleSettings;
        private System.Windows.Forms.Button btn_tripSettings;
        private System.Windows.Forms.Button btn_setSalaries;
        private System.Windows.Forms.Button btn_setFuelCosts;
        private System.Windows.Forms.Button btn_calculateDailyProfit;
    }
}