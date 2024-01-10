namespace project2_begin.Forms.User
{
    partial class UserSearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.lbl_deparature = new System.Windows.Forms.Label();
            this.comboBox_deparature = new System.Windows.Forms.ComboBox();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.comboBox_destination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_passengerCount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_vehicles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_vehicleType = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.Location = new System.Drawing.Point(203, 357);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(247, 50);
            this.btn_mainmenu.TabIndex = 14;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // lbl_deparature
            // 
            this.lbl_deparature.AutoSize = true;
            this.lbl_deparature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deparature.Location = new System.Drawing.Point(75, 123);
            this.lbl_deparature.Name = "lbl_deparature";
            this.lbl_deparature.Size = new System.Drawing.Size(157, 29);
            this.lbl_deparature.TabIndex = 25;
            this.lbl_deparature.Text = "Deparature :";
            // 
            // comboBox_deparature
            // 
            this.comboBox_deparature.BackColor = System.Drawing.Color.Azure;
            this.comboBox_deparature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_deparature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_deparature.FormattingEnabled = true;
            this.comboBox_deparature.Location = new System.Drawing.Point(239, 120);
            this.comboBox_deparature.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_deparature.Name = "comboBox_deparature";
            this.comboBox_deparature.Size = new System.Drawing.Size(160, 37);
            this.comboBox_deparature.TabIndex = 26;
            this.comboBox_deparature.SelectedIndexChanged += new System.EventHandler(this.comboBox_deparature_SelectedIndexChanged);
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destination.Location = new System.Drawing.Point(75, 167);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(158, 29);
            this.lbl_destination.TabIndex = 27;
            this.lbl_destination.Text = "Destination :";
            // 
            // comboBox_destination
            // 
            this.comboBox_destination.BackColor = System.Drawing.Color.Azure;
            this.comboBox_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_destination.FormattingEnabled = true;
            this.comboBox_destination.Location = new System.Drawing.Point(239, 164);
            this.comboBox_destination.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_destination.Name = "comboBox_destination";
            this.comboBox_destination.Size = new System.Drawing.Size(160, 37);
            this.comboBox_destination.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Passanger count :";
            // 
            // txtbox_passengerCount
            // 
            this.txtbox_passengerCount.BackColor = System.Drawing.Color.Azure;
            this.txtbox_passengerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_passengerCount.Location = new System.Drawing.Point(239, 207);
            this.txtbox_passengerCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_passengerCount.Name = "txtbox_passengerCount";
            this.txtbox_passengerCount.Size = new System.Drawing.Size(160, 34);
            this.txtbox_passengerCount.TabIndex = 30;
            this.txtbox_passengerCount.Text = "1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(409, 34);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView_vehicles
            // 
            this.dataGridView_vehicles.AllowUserToAddRows = false;
            this.dataGridView_vehicles.AllowUserToDeleteRows = false;
            this.dataGridView_vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_vehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_vehicles.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_vehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_vehicles.Location = new System.Drawing.Point(457, 11);
            this.dataGridView_vehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_vehicles.Name = "dataGridView_vehicles";
            this.dataGridView_vehicles.ReadOnly = true;
            this.dataGridView_vehicles.RowHeadersWidth = 47;
            this.dataGridView_vehicles.Size = new System.Drawing.Size(749, 406);
            this.dataGridView_vehicles.TabIndex = 32;
            this.dataGridView_vehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_vehicles_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vehicle type :";
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
            this.comboBox_vehicleType.Location = new System.Drawing.Point(239, 76);
            this.comboBox_vehicleType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_vehicleType.Name = "comboBox_vehicleType";
            this.comboBox_vehicleType.Size = new System.Drawing.Size(160, 37);
            this.comboBox_vehicleType.TabIndex = 34;
            this.comboBox_vehicleType.SelectedIndexChanged += new System.EventHandler(this.comboBox_vehicleType_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Azure;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(203, 249);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(247, 50);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Azure;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(203, 303);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(247, 50);
            this.btn_continue.TabIndex = 36;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // UserSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1219, 434);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.comboBox_vehicleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_vehicles);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_passengerCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_destination);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.comboBox_deparature);
            this.Controls.Add(this.lbl_deparature);
            this.Controls.Add(this.btn_mainmenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Label lbl_deparature;
        private System.Windows.Forms.ComboBox comboBox_deparature;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.ComboBox comboBox_destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_passengerCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView_vehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_vehicleType;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_continue;
    }
}