namespace project2_begin.Forms.CompanyForms
{
    partial class CompanyTripAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_vehicles = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addTrip = new System.Windows.Forms.Button();
            this.btn_tripMenu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_vehiclePassengersCount = new System.Windows.Forms.Label();
            this.lbl_vehicleName = new System.Windows.Forms.Label();
            this.lbl_vehicleType = new System.Windows.Forms.Label();
            this.lbl_vehicleId = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_vehicles
            // 
            this.dataGridView_vehicles.AllowUserToAddRows = false;
            this.dataGridView_vehicles.AllowUserToDeleteRows = false;
            this.dataGridView_vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_vehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_vehicles.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_vehicles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_vehicles.Location = new System.Drawing.Point(13, 7);
            this.dataGridView_vehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_vehicles.Name = "dataGridView_vehicles";
            this.dataGridView_vehicles.ReadOnly = true;
            this.dataGridView_vehicles.RowHeadersWidth = 47;
            this.dataGridView_vehicles.Size = new System.Drawing.Size(679, 444);
            this.dataGridView_vehicles.TabIndex = 2;
            this.dataGridView_vehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_vehicles_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 700;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Location = new System.Drawing.Point(731, 145);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(409, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(893, 283);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 50);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Clear";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addTrip
            // 
            this.btn_addTrip.BackColor = System.Drawing.Color.Azure;
            this.btn_addTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTrip.Location = new System.Drawing.Point(731, 283);
            this.btn_addTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addTrip.Name = "btn_addTrip";
            this.btn_addTrip.Size = new System.Drawing.Size(147, 50);
            this.btn_addTrip.TabIndex = 13;
            this.btn_addTrip.Text = "Add";
            this.btn_addTrip.UseVisualStyleBackColor = false;
            this.btn_addTrip.Click += new System.EventHandler(this.btn_addTrip_Click);
            // 
            // btn_tripMenu
            // 
            this.btn_tripMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_tripMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tripMenu.Location = new System.Drawing.Point(790, 401);
            this.btn_tripMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tripMenu.Name = "btn_tripMenu";
            this.btn_tripMenu.Size = new System.Drawing.Size(224, 50);
            this.btn_tripMenu.TabIndex = 14;
            this.btn_tripMenu.Text = "Trip Menu";
            this.btn_tripMenu.UseVisualStyleBackColor = false;
            this.btn_tripMenu.Click += new System.EventHandler(this.btn_tripMenu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(731, 188);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(409, 34);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(731, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(173, 29);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vehicle Id:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Vehicle Name:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Passengers Count:";
            // 
            // lbl_vehiclePassengersCount
            // 
            this.lbl_vehiclePassengersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vehiclePassengersCount.AutoSize = true;
            this.lbl_vehiclePassengersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiclePassengersCount.ForeColor = System.Drawing.Color.Teal;
            this.lbl_vehiclePassengersCount.Location = new System.Drawing.Point(969, 98);
            this.lbl_vehiclePassengersCount.Name = "lbl_vehiclePassengersCount";
            this.lbl_vehiclePassengersCount.Size = new System.Drawing.Size(0, 29);
            this.lbl_vehiclePassengersCount.TabIndex = 20;
            // 
            // lbl_vehicleName
            // 
            this.lbl_vehicleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vehicleName.AutoSize = true;
            this.lbl_vehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleName.ForeColor = System.Drawing.Color.Teal;
            this.lbl_vehicleName.Location = new System.Drawing.Point(919, 70);
            this.lbl_vehicleName.Name = "lbl_vehicleName";
            this.lbl_vehicleName.Size = new System.Drawing.Size(0, 29);
            this.lbl_vehicleName.TabIndex = 21;
            // 
            // lbl_vehicleType
            // 
            this.lbl_vehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vehicleType.AutoSize = true;
            this.lbl_vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleType.ForeColor = System.Drawing.Color.Teal;
            this.lbl_vehicleType.Location = new System.Drawing.Point(913, 41);
            this.lbl_vehicleType.Name = "lbl_vehicleType";
            this.lbl_vehicleType.Size = new System.Drawing.Size(0, 29);
            this.lbl_vehicleType.TabIndex = 22;
            // 
            // lbl_vehicleId
            // 
            this.lbl_vehicleId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vehicleId.AutoSize = true;
            this.lbl_vehicleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleId.ForeColor = System.Drawing.Color.Teal;
            this.lbl_vehicleId.Location = new System.Drawing.Point(867, 11);
            this.lbl_vehicleId.Name = "lbl_vehicleId";
            this.lbl_vehicleId.Size = new System.Drawing.Size(0, 29);
            this.lbl_vehicleId.TabIndex = 23;
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(711, 359);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 29);
            this.lbl_info.TabIndex = 24;
            // 
            // CompanyTripAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1166, 472);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_vehicleId);
            this.Controls.Add(this.lbl_vehicleType);
            this.Controls.Add(this.lbl_vehicleName);
            this.Controls.Add(this.lbl_vehiclePassengersCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_tripMenu);
            this.Controls.Add(this.btn_addTrip);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView_vehicles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyTripAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyTripAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_vehicles;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_addTrip;
        private System.Windows.Forms.Button btn_tripMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_vehiclePassengersCount;
        private System.Windows.Forms.Label lbl_vehicleName;
        private System.Windows.Forms.Label lbl_vehicleType;
        private System.Windows.Forms.Label lbl_vehicleId;
        private System.Windows.Forms.Label lbl_info;
    }
}