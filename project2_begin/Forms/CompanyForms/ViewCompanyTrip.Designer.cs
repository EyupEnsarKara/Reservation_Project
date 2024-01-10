namespace project2_begin.Forms.CompanyForms
{
    partial class ViewCompanyTrip
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
            this.dataGridView_trips = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addTrip = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trips)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_trips
            // 
            this.dataGridView_trips.AllowUserToAddRows = false;
            this.dataGridView_trips.AllowUserToDeleteRows = false;
            this.dataGridView_trips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_trips.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_trips.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_trips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_trips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_trips.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_trips.Location = new System.Drawing.Point(13, 14);
            this.dataGridView_trips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_trips.Name = "dataGridView_trips";
            this.dataGridView_trips.ReadOnly = true;
            this.dataGridView_trips.RowHeadersWidth = 47;
            this.dataGridView_trips.Size = new System.Drawing.Size(753, 420);
            this.dataGridView_trips.TabIndex = 1;
            this.dataGridView_trips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_trips_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(903, 177);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 50);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addTrip
            // 
            this.btn_addTrip.BackColor = System.Drawing.Color.Azure;
            this.btn_addTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTrip.Location = new System.Drawing.Point(903, 123);
            this.btn_addTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addTrip.Name = "btn_addTrip";
            this.btn_addTrip.Size = new System.Drawing.Size(147, 50);
            this.btn_addTrip.TabIndex = 13;
            this.btn_addTrip.Text = "Add Trip";
            this.btn_addTrip.UseVisualStyleBackColor = false;
            this.btn_addTrip.Click += new System.EventHandler(this.btn_addTrip_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(773, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(409, 34);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(773, 256);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(13, 29);
            this.lbl_info.TabIndex = 17;
            this.lbl_info.Text = "\r\n";
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.Azure;
            this.btn_mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(816, 384);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(329, 50);
            this.btn_mainMenu.TabIndex = 18;
            this.btn_mainMenu.Text = "Company Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // ViewCompanyTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1189, 447);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_addTrip);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView_trips);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewCompanyTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_trips;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_addTrip;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_mainMenu;
    }
}