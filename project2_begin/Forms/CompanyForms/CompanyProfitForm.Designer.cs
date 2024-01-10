namespace project2_begin.Forms.CompanyForms
{
    partial class CompanyProfitForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_dailyProfit = new System.Windows.Forms.Label();
            this.btn_calculateDailyProfit = new System.Windows.Forms.Button();
            this.btn_calculateAllProfit = new System.Windows.Forms.Button();
            this.lbl_allProfit = new System.Windows.Forms.Label();
            this.btn_companyMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 14);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(411, 34);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // lbl_dailyProfit
            // 
            this.lbl_dailyProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dailyProfit.AutoSize = true;
            this.lbl_dailyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dailyProfit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dailyProfit.Location = new System.Drawing.Point(151, 152);
            this.lbl_dailyProfit.Name = "lbl_dailyProfit";
            this.lbl_dailyProfit.Size = new System.Drawing.Size(0, 29);
            this.lbl_dailyProfit.TabIndex = 18;
            // 
            // btn_calculateDailyProfit
            // 
            this.btn_calculateDailyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateDailyProfit.Location = new System.Drawing.Point(40, 79);
            this.btn_calculateDailyProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calculateDailyProfit.Name = "btn_calculateDailyProfit";
            this.btn_calculateDailyProfit.Size = new System.Drawing.Size(356, 50);
            this.btn_calculateDailyProfit.TabIndex = 19;
            this.btn_calculateDailyProfit.Text = "Calculate Daily Profit";
            this.btn_calculateDailyProfit.UseVisualStyleBackColor = true;
            this.btn_calculateDailyProfit.Click += new System.EventHandler(this.btn_calculateDailyProfit_Click);
            // 
            // btn_calculateAllProfit
            // 
            this.btn_calculateAllProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateAllProfit.Location = new System.Drawing.Point(37, 207);
            this.btn_calculateAllProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calculateAllProfit.Name = "btn_calculateAllProfit";
            this.btn_calculateAllProfit.Size = new System.Drawing.Size(359, 50);
            this.btn_calculateAllProfit.TabIndex = 20;
            this.btn_calculateAllProfit.Text = "Calculate Profit";
            this.btn_calculateAllProfit.UseVisualStyleBackColor = true;
            this.btn_calculateAllProfit.Click += new System.EventHandler(this.btn_calculateAllProfit_Click);
            // 
            // lbl_allProfit
            // 
            this.lbl_allProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_allProfit.AutoSize = true;
            this.lbl_allProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allProfit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_allProfit.Location = new System.Drawing.Point(151, 282);
            this.lbl_allProfit.Name = "lbl_allProfit";
            this.lbl_allProfit.Size = new System.Drawing.Size(0, 29);
            this.lbl_allProfit.TabIndex = 21;
            // 
            // btn_companyMenu
            // 
            this.btn_companyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyMenu.Location = new System.Drawing.Point(70, 335);
            this.btn_companyMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_companyMenu.Name = "btn_companyMenu";
            this.btn_companyMenu.Size = new System.Drawing.Size(292, 50);
            this.btn_companyMenu.TabIndex = 22;
            this.btn_companyMenu.Text = "Company Menu";
            this.btn_companyMenu.UseVisualStyleBackColor = true;
            this.btn_companyMenu.Click += new System.EventHandler(this.btn_companyMenu_Click);
            // 
            // CompanyProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(451, 438);
            this.Controls.Add(this.btn_companyMenu);
            this.Controls.Add(this.lbl_allProfit);
            this.Controls.Add(this.btn_calculateAllProfit);
            this.Controls.Add(this.btn_calculateDailyProfit);
            this.Controls.Add(this.lbl_dailyProfit);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompanyProfitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyProfitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_dailyProfit;
        private System.Windows.Forms.Button btn_calculateDailyProfit;
        private System.Windows.Forms.Button btn_calculateAllProfit;
        private System.Windows.Forms.Label lbl_allProfit;
        private System.Windows.Forms.Button btn_companyMenu;
    }
}