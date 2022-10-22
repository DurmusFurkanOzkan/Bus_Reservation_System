
namespace Bus_Reservation_System
{
    partial class Voyage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voyage));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.msk_time = new System.Windows.Forms.MaskedTextBox();
            this.msk_date = new System.Windows.Forms.MaskedTextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.txt_departure = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_driver);
            this.groupBox4.Controls.Add(this.txt_destination);
            this.groupBox4.Controls.Add(this.msk_time);
            this.groupBox4.Controls.Add(this.msk_date);
            this.groupBox4.Controls.Add(this.txt_price);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.txt_departure);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(12, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 306);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Voyage";
            // 
            // msk_time
            // 
            this.msk_time.Location = new System.Drawing.Point(174, 131);
            this.msk_time.Mask = "00:00";
            this.msk_time.Name = "msk_time";
            this.msk_time.Size = new System.Drawing.Size(149, 22);
            this.msk_time.TabIndex = 20;
            this.msk_time.ValidatingType = typeof(System.DateTime);
            // 
            // msk_date
            // 
            this.msk_date.Location = new System.Drawing.Point(173, 97);
            this.msk_date.Mask = "00/00/0000";
            this.msk_date.Name = "msk_date";
            this.msk_date.Size = new System.Drawing.Size(149, 22);
            this.msk_date.TabIndex = 20;
            this.msk_date.ValidatingType = typeof(System.DateTime);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(176, 200);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(148, 22);
            this.txt_price.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(108, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 24);
            this.label18.TabIndex = 18;
            this.label18.Text = "Price:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(96, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 24);
            this.label17.TabIndex = 16;
            this.label17.Text = "Driver:";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(133, 242);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 53);
            this.button15.TabIndex = 15;
            this.button15.Text = "Save";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // txt_departure
            // 
            this.txt_departure.Location = new System.Drawing.Point(175, 26);
            this.txt_departure.Name = "txt_departure";
            this.txt_departure.Size = new System.Drawing.Size(148, 22);
            this.txt_departure.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(108, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(111, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(48, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "Destination:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(63, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Departure:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(174, 61);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(148, 22);
            this.txt_destination.TabIndex = 21;
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(176, 162);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(148, 24);
            this.cmb_driver.TabIndex = 22;
            // 
            // Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Voyage";
            this.Text = "Voyage";
            this.Load += new System.EventHandler(this.Voyage_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox msk_time;
        private System.Windows.Forms.MaskedTextBox msk_date;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txt_departure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.ComboBox cmb_driver;
    }
}