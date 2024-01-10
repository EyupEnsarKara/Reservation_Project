namespace project2_begin.Forms.AdminForms
{
    partial class AdminSetServiceCostForm
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
            this.btn_setcost = new System.Windows.Forms.Button();
            this.txtbox_serviceCost = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_adminMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_setcost
            // 
            this.btn_setcost.BackColor = System.Drawing.Color.Azure;
            this.btn_setcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setcost.Location = new System.Drawing.Point(102, 114);
            this.btn_setcost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setcost.Name = "btn_setcost";
            this.btn_setcost.Size = new System.Drawing.Size(164, 47);
            this.btn_setcost.TabIndex = 2;
            this.btn_setcost.Text = "Set Cost";
            this.btn_setcost.UseVisualStyleBackColor = false;
            this.btn_setcost.Click += new System.EventHandler(this.btn_setcost_Click);
            // 
            // txtbox_serviceCost
            // 
            this.txtbox_serviceCost.BackColor = System.Drawing.Color.Azure;
            this.txtbox_serviceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_serviceCost.Location = new System.Drawing.Point(102, 76);
            this.txtbox_serviceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_serviceCost.Name = "txtbox_serviceCost";
            this.txtbox_serviceCost.Size = new System.Drawing.Size(164, 34);
            this.txtbox_serviceCost.TabIndex = 3;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(31, 183);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 29);
            this.lbl_info.TabIndex = 5;
            // 
            // btn_adminMenu
            // 
            this.btn_adminMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_adminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminMenu.Location = new System.Drawing.Point(76, 226);
            this.btn_adminMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adminMenu.Name = "btn_adminMenu";
            this.btn_adminMenu.Size = new System.Drawing.Size(212, 47);
            this.btn_adminMenu.TabIndex = 6;
            this.btn_adminMenu.Text = "Admin Menu";
            this.btn_adminMenu.UseVisualStyleBackColor = false;
            this.btn_adminMenu.Click += new System.EventHandler(this.btn_adminMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service Cost";
            // 
            // AdminSetServiceCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(362, 316);
            this.Controls.Add(this.btn_adminMenu);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_serviceCost);
            this.Controls.Add(this.btn_setcost);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminSetServiceCostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSetServiceCostForm";
            this.Load += new System.EventHandler(this.AdminSetServiceCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setcost;
        private System.Windows.Forms.TextBox txtbox_serviceCost;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_adminMenu;
        private System.Windows.Forms.Label label1;
    }
}