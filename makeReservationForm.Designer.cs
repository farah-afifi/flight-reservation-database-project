namespace FlightReservationSystem
{
    partial class makeReservationForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reserveBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TO = new System.Windows.Forms.TextBox();
            this.FROM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flight_ReservationDataSet1 = new FlightReservationSystem.Flight_ReservationDataSet1();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSet1TableAdapters.FLIGHTTableAdapter();
            this.dATEANDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSTOPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURECITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 451);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // reserveBTN
            // 
            this.reserveBTN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.reserveBTN.Location = new System.Drawing.Point(620, 483);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(137, 44);
            this.reserveBTN.TabIndex = 22;
            this.reserveBTN.Text = "Reserve";
            this.reserveBTN.UseVisualStyleBackColor = true;
            this.reserveBTN.Click += new System.EventHandler(this.reserveBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.backBTN.Location = new System.Drawing.Point(436, 483);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(137, 44);
            this.backBTN.TabIndex = 21;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(38, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "now you can choose the flight number you want to reserve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(62, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "available flights:";
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 200);
            this.dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(680, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TO
            // 
            this.TO.Location = new System.Drawing.Point(480, 58);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(237, 20);
            this.TO.TabIndex = 16;
            // 
            // FROM
            // 
            this.FROM.Location = new System.Drawing.Point(127, 58);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(237, 20);
            this.FROM.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(428, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(49, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "choose from which country to which country do you want to update your ticket to:";
            // 
            // flight_ReservationDataSet1
            // 
            this.flight_ReservationDataSet1.DataSetName = "Flight_ReservationDataSet1";
            this.flight_ReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.flight_ReservationDataSet1;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
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
            // makeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
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
            this.Name = "makeReservationForm";
            this.Text = "makeReservationForm";
            this.Load += new System.EventHandler(this.makeReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button reserveBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TO;
        private System.Windows.Forms.TextBox FROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Flight_ReservationDataSet1 flight_ReservationDataSet1;
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
    }
}