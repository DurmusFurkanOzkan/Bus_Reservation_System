
namespace Bus_Reservation_System
{
    partial class Reservation
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.msk_national_number = new System.Windows.Forms.MaskedTextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_voyage_id = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Seats = new System.Windows.Forms.GroupBox();
            this.seat11 = new System.Windows.Forms.Button();
            this.seat10 = new System.Windows.Forms.Button();
            this.seat9 = new System.Windows.Forms.Button();
            this.seat8 = new System.Windows.Forms.Button();
            this.seat7 = new System.Windows.Forms.Button();
            this.seat6 = new System.Windows.Forms.Button();
            this.seat4 = new System.Windows.Forms.Button();
            this.seat3 = new System.Windows.Forms.Button();
            this.seat5 = new System.Windows.Forms.Button();
            this.seat2 = new System.Windows.Forms.Button();
            this.seat1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Voyages = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voyageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Reservation_SystemDataSet = new Bus_Reservation_System.Bus_Reservation_SystemDataSet();
            this.voyageTableAdapter = new Bus_Reservation_System.Bus_Reservation_SystemDataSetTableAdapters.VoyageTableAdapter();
            this.groupBox5.SuspendLayout();
            this.Seats.SuspendLayout();
            this.Voyages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Reservation_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.msk_national_number);
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txt_voyage_id);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(70, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 174);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reservation";
            // 
            // msk_national_number
            // 
            this.msk_national_number.Location = new System.Drawing.Point(166, 59);
            this.msk_national_number.Mask = "00000000000";
            this.msk_national_number.Name = "msk_national_number";
            this.msk_national_number.Size = new System.Drawing.Size(148, 22);
            this.msk_national_number.TabIndex = 23;
            this.msk_national_number.ValidatingType = typeof(int);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(92, 106);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(142, 43);
            this.button16.TabIndex = 19;
            this.button16.Text = "Choose a Seat";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(39, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 24);
            this.label22.TabIndex = 19;
            this.label22.Text = "National ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(27, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 24);
            this.label21.TabIndex = 19;
            // 
            // txt_voyage_id
            // 
            this.txt_voyage_id.Enabled = false;
            this.txt_voyage_id.Location = new System.Drawing.Point(166, 25);
            this.txt_voyage_id.Name = "txt_voyage_id";
            this.txt_voyage_id.Size = new System.Drawing.Size(148, 22);
            this.txt_voyage_id.TabIndex = 22;
            this.txt_voyage_id.TextChanged += new System.EventHandler(this.txt_voyage_id_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(52, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 24);
            this.label19.TabIndex = 21;
            this.label19.Text = "Voyage ID:";
            // 
            // Seats
            // 
            this.Seats.Controls.Add(this.seat11);
            this.Seats.Controls.Add(this.seat10);
            this.Seats.Controls.Add(this.seat9);
            this.Seats.Controls.Add(this.seat8);
            this.Seats.Controls.Add(this.seat7);
            this.Seats.Controls.Add(this.seat6);
            this.Seats.Controls.Add(this.seat4);
            this.Seats.Controls.Add(this.seat3);
            this.Seats.Controls.Add(this.seat5);
            this.Seats.Controls.Add(this.seat2);
            this.Seats.Controls.Add(this.seat1);
            this.Seats.Controls.Add(this.button1);
            this.Seats.Location = new System.Drawing.Point(566, 12);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(177, 292);
            this.Seats.TabIndex = 20;
            this.Seats.TabStop = false;
            this.Seats.Text = "Seats";
            this.Seats.Visible = false;
            // 
            // seat11
            // 
            this.seat11.Location = new System.Drawing.Point(108, 246);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(45, 39);
            this.seat11.TabIndex = 10;
            this.seat11.Text = "11";
            this.seat11.UseVisualStyleBackColor = true;
            this.seat11.Click += new System.EventHandler(this.seat11_Click);
            // 
            // seat10
            // 
            this.seat10.Location = new System.Drawing.Point(57, 246);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(45, 39);
            this.seat10.TabIndex = 9;
            this.seat10.Text = "10";
            this.seat10.UseVisualStyleBackColor = true;
            this.seat10.Click += new System.EventHandler(this.seat10_Click);
            // 
            // seat9
            // 
            this.seat9.Location = new System.Drawing.Point(6, 246);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(45, 39);
            this.seat9.TabIndex = 8;
            this.seat9.Text = "9";
            this.seat9.UseVisualStyleBackColor = true;
            this.seat9.Click += new System.EventHandler(this.seat9_Click);
            // 
            // seat8
            // 
            this.seat8.Location = new System.Drawing.Point(57, 201);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(45, 39);
            this.seat8.TabIndex = 7;
            this.seat8.Text = "8";
            this.seat8.UseVisualStyleBackColor = true;
            this.seat8.Click += new System.EventHandler(this.seat8_Click);
            // 
            // seat7
            // 
            this.seat7.Location = new System.Drawing.Point(6, 201);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(45, 39);
            this.seat7.TabIndex = 6;
            this.seat7.Text = "7";
            this.seat7.UseVisualStyleBackColor = true;
            this.seat7.Click += new System.EventHandler(this.seat7_Click);
            // 
            // seat6
            // 
            this.seat6.Location = new System.Drawing.Point(57, 156);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(45, 39);
            this.seat6.TabIndex = 5;
            this.seat6.Text = "6";
            this.seat6.UseVisualStyleBackColor = true;
            this.seat6.Click += new System.EventHandler(this.seat6_Click);
            // 
            // seat4
            // 
            this.seat4.Location = new System.Drawing.Point(57, 111);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(45, 39);
            this.seat4.TabIndex = 4;
            this.seat4.Text = "4";
            this.seat4.UseVisualStyleBackColor = true;
            this.seat4.Click += new System.EventHandler(this.seat4_Click);
            // 
            // seat3
            // 
            this.seat3.Location = new System.Drawing.Point(6, 111);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(45, 39);
            this.seat3.TabIndex = 3;
            this.seat3.Text = "3";
            this.seat3.UseVisualStyleBackColor = true;
            this.seat3.Click += new System.EventHandler(this.seat3_Click);
            // 
            // seat5
            // 
            this.seat5.Location = new System.Drawing.Point(6, 156);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(45, 39);
            this.seat5.TabIndex = 3;
            this.seat5.Text = "5";
            this.seat5.UseVisualStyleBackColor = true;
            this.seat5.Click += new System.EventHandler(this.seat5_Click);
            // 
            // seat2
            // 
            this.seat2.Location = new System.Drawing.Point(57, 66);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(45, 39);
            this.seat2.TabIndex = 2;
            this.seat2.Text = "2";
            this.seat2.UseVisualStyleBackColor = true;
            this.seat2.Click += new System.EventHandler(this.seat2_Click);
            // 
            // seat1
            // 
            this.seat1.Location = new System.Drawing.Point(6, 66);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(45, 39);
            this.seat1.TabIndex = 1;
            this.seat1.Tag = "";
            this.seat1.Text = "1";
            this.seat1.UseVisualStyleBackColor = true;
            this.seat1.Click += new System.EventHandler(this.seat1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 0;
            this.button1.Tag = "";
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Voyages
            // 
            this.Voyages.Controls.Add(this.dataGridView1);
            this.Voyages.Location = new System.Drawing.Point(1, 303);
            this.Voyages.Name = "Voyages";
            this.Voyages.Size = new System.Drawing.Size(878, 271);
            this.Voyages.TabIndex = 22;
            this.Voyages.TabStop = false;
            this.Voyages.Text = "Voyages";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.departurepointDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voyageBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departurepointDataGridViewTextBoxColumn
            // 
            this.departurepointDataGridViewTextBoxColumn.DataPropertyName = "Departure_point";
            this.departurepointDataGridViewTextBoxColumn.HeaderText = "Departure_point";
            this.departurepointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departurepointDataGridViewTextBoxColumn.Name = "departurepointDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // voyageBindingSource
            // 
            this.voyageBindingSource.DataMember = "Voyage";
            this.voyageBindingSource.DataSource = this.bus_Reservation_SystemDataSet;
            // 
            // bus_Reservation_SystemDataSet
            // 
            this.bus_Reservation_SystemDataSet.DataSetName = "Bus_Reservation_SystemDataSet";
            this.bus_Reservation_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voyageTableAdapter
            // 
            this.voyageTableAdapter.ClearBeforeFill = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 572);
            this.Controls.Add(this.Voyages);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.groupBox5);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Seats.ResumeLayout(false);
            this.Voyages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Reservation_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_voyage_id;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox Seats;
        private System.Windows.Forms.Button seat11;
        private System.Windows.Forms.Button seat10;
        private System.Windows.Forms.Button seat9;
        private System.Windows.Forms.Button seat8;
        private System.Windows.Forms.Button seat7;
        private System.Windows.Forms.Button seat6;
        private System.Windows.Forms.Button seat4;
        private System.Windows.Forms.Button seat3;
        private System.Windows.Forms.Button seat5;
        private System.Windows.Forms.Button seat2;
        private System.Windows.Forms.Button seat1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Voyages;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bus_Reservation_SystemDataSet bus_Reservation_SystemDataSet;
        private System.Windows.Forms.BindingSource voyageBindingSource;
        private Bus_Reservation_SystemDataSetTableAdapters.VoyageTableAdapter voyageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurepointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox msk_national_number;
    }
}