namespace FlightReservationSystem
{
    partial class UpdateReservationForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flight_ReservationDataSet1 = new FlightReservationSystem.Flight_ReservationDataSet1();
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tICKETTableAdapter = new FlightReservationSystem.Flight_ReservationDataSet1TableAdapters.TICKETTableAdapter();
            this.pASSENGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NextBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pASSENGERIDDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.sEATNODataGridViewTextBoxColumn,
            this.tICKETNODataGridViewTextBoxColumn,
            this.cLASSDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.pILOTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tICKETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // flight_ReservationDataSet1
            // 
            this.flight_ReservationDataSet1.DataSetName = "Flight_ReservationDataSet1";
            this.flight_ReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.flight_ReservationDataSet1;
            // 
            // tICKETTableAdapter
            // 
            this.tICKETTableAdapter.ClearBeforeFill = true;
            // 
            // pASSENGERIDDataGridViewTextBoxColumn
            // 
            this.pASSENGERIDDataGridViewTextBoxColumn.DataPropertyName = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.HeaderText = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.Name = "pASSENGERIDDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // sEATNODataGridViewTextBoxColumn
            // 
            this.sEATNODataGridViewTextBoxColumn.DataPropertyName = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.HeaderText = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.Name = "sEATNODataGridViewTextBoxColumn";
            // 
            // tICKETNODataGridViewTextBoxColumn
            // 
            this.tICKETNODataGridViewTextBoxColumn.DataPropertyName = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.HeaderText = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.Name = "tICKETNODataGridViewTextBoxColumn";
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "your  current bookings are:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NextBTN
            // 
            this.NextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NextBTN.Location = new System.Drawing.Point(615, 395);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(137, 44);
            this.NextBTN.TabIndex = 3;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backBTN.Location = new System.Drawing.Point(451, 395);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(137, 44);
            this.backBTN.TabIndex = 4;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(31, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "choose the ticket number of the reservation you want to update:";
            // 
            // UpdateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateReservationForm";
            this.Text = "Update Reservation";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Flight_ReservationDataSet1 flight_ReservationDataSet1;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private Flight_ReservationDataSet1TableAdapters.TICKETTableAdapter tICKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSENGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tICKETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label2;
    }
}