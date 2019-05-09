namespace FlightReservationSystem
{
    partial class updateReservationForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FROM = new System.Windows.Forms.TextBox();
            this.TO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSTOPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_ReservationDataSet1 = new FlightReservationSystem.Flight_ReservationDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.flightReservationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSet1TableAdapters.FLIGHTTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.reserveBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose from which country to which country do you want to update your ticket to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // FROM
            // 
            this.FROM.Location = new System.Drawing.Point(123, 99);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(237, 24);
            this.FROM.TabIndex = 3;
            // 
            // TO
            // 
            this.TO.Location = new System.Drawing.Point(476, 99);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(237, 24);
            this.TO.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATEANDTIMEDataGridViewTextBoxColumn,
            this.dESTINATIONCITYDataGridViewTextBoxColumn,
            this.pILOTIDDataGridViewTextBoxColumn,
            this.nSTOPSDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn,
            this.dEPARTURECITYDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.nAVAILABLESEATSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLIGHTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 200);
            this.dataGridView1.TabIndex = 6;
            // 
            // dATEANDTIMEDataGridViewTextBoxColumn
            // 
            this.dATEANDTIMEDataGridViewTextBoxColumn.DataPropertyName = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.HeaderText = "DATE_AND_TIME";
            this.dATEANDTIMEDataGridViewTextBoxColumn.Name = "dATEANDTIMEDataGridViewTextBoxColumn";
            // 
            // dESTINATIONCITYDataGridViewTextBoxColumn
            // 
            this.dESTINATIONCITYDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.HeaderText = "DESTINATION_CITY";
            this.dESTINATIONCITYDataGridViewTextBoxColumn.Name = "dESTINATIONCITYDataGridViewTextBoxColumn";
            // 
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            // 
            // nSTOPSDataGridViewTextBoxColumn
            // 
            this.nSTOPSDataGridViewTextBoxColumn.DataPropertyName = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.HeaderText = "N_STOPS";
            this.nSTOPSDataGridViewTextBoxColumn.Name = "nSTOPSDataGridViewTextBoxColumn";
            // 
            // dURATIONDataGridViewTextBoxColumn
            // 
            this.dURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.Name = "dURATIONDataGridViewTextBoxColumn";
            // 
            // dEPARTURECITYDataGridViewTextBoxColumn
            // 
            this.dEPARTURECITYDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_CITY";
            this.dEPARTURECITYDataGridViewTextBoxColumn.Name = "dEPARTURECITYDataGridViewTextBoxColumn";
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // nAVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "N_AVAILABLESEATS";
            this.nAVAILABLESEATSDataGridViewTextBoxColumn.Name = "nAVAILABLESEATSDataGridViewTextBoxColumn";
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.flight_ReservationDataSet1;
            // 
            // flight_ReservationDataSet1
            // 
            this.flight_ReservationDataSet1.DataSetName = "Flight_ReservationDataSet1";
            this.flight_ReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "available flights:";
            // 
            // flightReservationDataSet1BindingSource
            // 
            this.flightReservationDataSet1BindingSource.DataSource = this.flight_ReservationDataSet1;
            this.flightReservationDataSet1BindingSource.Position = 0;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "now you can choose the flight no you want to update your ticket to:";
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(432, 524);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(137, 44);
            this.backBTN.TabIndex = 9;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // reserveBTN
            // 
            this.reserveBTN.Location = new System.Drawing.Point(616, 524);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(137, 44);
            this.reserveBTN.TabIndex = 10;
            this.reserveBTN.Text = "Reserve";
            this.reserveBTN.UseVisualStyleBackColor = true;
            this.reserveBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // updateReservationForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reserveBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "updateReservationForm2";
            this.Text = "updateReservationForm2";
            this.Load += new System.EventHandler(this.updateReservationForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FROM;
        private System.Windows.Forms.TextBox TO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource flightReservationDataSet1BindingSource;
        private Flight_ReservationDataSet1 flight_ReservationDataSet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Flight_ReservationDataSet1TableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEANDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSTOPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURECITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAVAILABLESEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button reserveBTN;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}