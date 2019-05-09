namespace FlightReservationSystem
{
    partial class ShowTicketsForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.flight_ReservationDataSet = new FlightReservationSystem.Flight_ReservationDataSet();
            this.flightReservationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter();
            this.fLIGHTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pASSENGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tICKETTableAdapter = new FlightReservationSystem.Flight_ReservationDataSetTableAdapters.TICKETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.backBtn.Location = new System.Drawing.Point(286, 296);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(154, 39);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // flight_ReservationDataSet
            // 
            this.flight_ReservationDataSet.DataSetName = "Flight_ReservationDataSet";
            this.flight_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightReservationDataSetBindingSource
            // 
            this.flightReservationDataSetBindingSource.DataSource = this.flight_ReservationDataSet;
            this.flightReservationDataSetBindingSource.Position = 0;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTBindingSource1
            // 
            this.fLIGHTBindingSource1.DataMember = "FLIGHT";
            this.fLIGHTBindingSource1.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 245);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pASSENGERIDDataGridViewTextBoxColumn
            // 
            this.pASSENGERIDDataGridViewTextBoxColumn.DataPropertyName = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.HeaderText = "PASSENGER_ID";
            this.pASSENGERIDDataGridViewTextBoxColumn.Name = "pASSENGERIDDataGridViewTextBoxColumn";
            this.pASSENGERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEATNODataGridViewTextBoxColumn
            // 
            this.sEATNODataGridViewTextBoxColumn.DataPropertyName = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.HeaderText = "SEAT_NO";
            this.sEATNODataGridViewTextBoxColumn.Name = "sEATNODataGridViewTextBoxColumn";
            this.sEATNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tICKETNODataGridViewTextBoxColumn
            // 
            this.tICKETNODataGridViewTextBoxColumn.DataPropertyName = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.HeaderText = "TICKET_NO";
            this.tICKETNODataGridViewTextBoxColumn.Name = "tICKETNODataGridViewTextBoxColumn";
            this.tICKETNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            this.cLASSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            this.fLIGHTNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pILOTIDDataGridViewTextBoxColumn
            // 
            this.pILOTIDDataGridViewTextBoxColumn.DataPropertyName = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.HeaderText = "PILOT_ID";
            this.pILOTIDDataGridViewTextBoxColumn.Name = "pILOTIDDataGridViewTextBoxColumn";
            this.pILOTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.flightReservationDataSetBindingSource;
            // 
            // tICKETTableAdapter
            // 
            this.tICKETTableAdapter.ClearBeforeFill = true;
            // 
            // ShowTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Name = "ShowTicketsForm";
            this.Text = "ShowTicketsForm";
            this.Load += new System.EventHandler(this.ShowTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flight_ReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightReservationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private Flight_ReservationDataSet flight_ReservationDataSet;
        private System.Windows.Forms.BindingSource flightReservationDataSetBindingSource;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Flight_ReservationDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private Flight_ReservationDataSetTableAdapters.TICKETTableAdapter tICKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSENGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tICKETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pILOTIDDataGridViewTextBoxColumn;
    }
}