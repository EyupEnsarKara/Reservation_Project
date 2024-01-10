namespace project2_begin.Forms.CompanyForms
{
    partial class CompanyVehicleSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox_fuelType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_vehicleType = new System.Windows.Forms.ComboBox();
            this.lbl_vehicleType = new System.Windows.Forms.Label();
            this.txtbox_vehiclecapacity = new System.Windows.Forms.TextBox();
            this.btn_deleteVehicle = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.AllowUserToAddRows = false;
            this.dataGridViewVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVehicles.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVehicles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVehicles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewVehicles.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.ReadOnly = true;
            this.dataGridViewVehicles.RowHeadersWidth = 47;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(809, 495);
            this.dataGridViewVehicles.TabIndex = 0;
            this.dataGridViewVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicles_CellClick);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(1052, 458);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(289, 50);
            this.btn_mainMenu.TabIndex = 15;
            this.btn_mainMenu.Text = "Company Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(1069, 185);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 29);
            this.lbl_info.TabIndex = 30;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1112, 221);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 50);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox_fuelType
            // 
            this.comboBox_fuelType.BackColor = System.Drawing.Color.Azure;
            this.comboBox_fuelType.CausesValidation = false;
            this.comboBox_fuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_fuelType.FormattingEnabled = true;
            this.comboBox_fuelType.Location = new System.Drawing.Point(1112, 123);
            this.comboBox_fuelType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_fuelType.Name = "comboBox_fuelType";
            this.comboBox_fuelType.Size = new System.Drawing.Size(160, 37);
            this.comboBox_fuelType.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(960, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fuel Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vehicle capacity :";
            // 
            // comboBox_vehicleType
            // 
            this.comboBox_vehicleType.BackColor = System.Drawing.Color.Azure;
            this.comboBox_vehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_vehicleType.FormattingEnabled = true;
            this.comboBox_vehicleType.Items.AddRange(new object[] {
            "Bus",
            "Train",
            "Airplane"});
            this.comboBox_vehicleType.Location = new System.Drawing.Point(1112, 11);
            this.comboBox_vehicleType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_vehicleType.Name = "comboBox_vehicleType";
            this.comboBox_vehicleType.Size = new System.Drawing.Size(160, 37);
            this.comboBox_vehicleType.TabIndex = 25;
            this.comboBox_vehicleType.SelectedIndexChanged += new System.EventHandler(this.comboBox_vehicleType_SelectedIndexChanged);
            // 
            // lbl_vehicleType
            // 
            this.lbl_vehicleType.AutoSize = true;
            this.lbl_vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleType.Location = new System.Drawing.Point(925, 19);
            this.lbl_vehicleType.Name = "lbl_vehicleType";
            this.lbl_vehicleType.Size = new System.Drawing.Size(180, 29);
            this.lbl_vehicleType.TabIndex = 24;
            this.lbl_vehicleType.Text = "Vehicle Type :";
            // 
            // txtbox_vehiclecapacity
            // 
            this.txtbox_vehiclecapacity.BackColor = System.Drawing.Color.Azure;
            this.txtbox_vehiclecapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_vehiclecapacity.Location = new System.Drawing.Point(1112, 65);
            this.txtbox_vehiclecapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_vehiclecapacity.Name = "txtbox_vehiclecapacity";
            this.txtbox_vehiclecapacity.Size = new System.Drawing.Size(160, 34);
            this.txtbox_vehiclecapacity.TabIndex = 23;
            // 
            // btn_deleteVehicle
            // 
            this.btn_deleteVehicle.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteVehicle.Location = new System.Drawing.Point(1112, 275);
            this.btn_deleteVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteVehicle.Name = "btn_deleteVehicle";
            this.btn_deleteVehicle.Size = new System.Drawing.Size(160, 50);
            this.btn_deleteVehicle.TabIndex = 31;
            this.btn_deleteVehicle.Text = "Delete";
            this.btn_deleteVehicle.UseVisualStyleBackColor = false;
            this.btn_deleteVehicle.Click += new System.EventHandler(this.btn_deleteVehicle_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Azure;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(1112, 329);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(160, 50);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // CompanyVehicleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1347, 519);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_deleteVehicle);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.comboBox_fuelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_vehicleType);
            this.Controls.Add(this.lbl_vehicleType);
            this.Controls.Add(this.txtbox_vehiclecapacity);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompanyVehicleSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyVehicleSet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBox_fuelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_vehicleType;
        private System.Windows.Forms.Label lbl_vehicleType;
        private System.Windows.Forms.TextBox txtbox_vehiclecapacity;
        private System.Windows.Forms.Button btn_deleteVehicle;
        private System.Windows.Forms.Button btn_clear;
    }
}