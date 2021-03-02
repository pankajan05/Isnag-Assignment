namespace Ayubo
{
    partial class Rent
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
            this.RentGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.textBoxStartingdate = new System.Windows.Forms.TextBox();
            this.EndingDate = new System.Windows.Forms.TextBox();
            this.VehicleNo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RentGridView
            // 
            this.RentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentGridView.Location = new System.Drawing.Point(360, 32);
            this.RentGridView.Name = "RentGridView";
            this.RentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentGridView.Size = new System.Drawing.Size(428, 366);
            this.RentGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicle Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starding Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ending Date";
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(125, 315);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDriver.TabIndex = 6;
            this.checkBoxDriver.Text = "Driver Needed?";
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            // 
            // textBoxStartingdate
            // 
            this.textBoxStartingdate.Location = new System.Drawing.Point(177, 191);
            this.textBoxStartingdate.Name = "textBoxStartingdate";
            this.textBoxStartingdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartingdate.TabIndex = 7;
            // 
            // EndingDate
            // 
            this.EndingDate.Location = new System.Drawing.Point(177, 254);
            this.EndingDate.Name = "EndingDate";
            this.EndingDate.Size = new System.Drawing.Size(100, 20);
            this.EndingDate.TabIndex = 8;
            // 
            // VehicleNo
            // 
            this.VehicleNo.FormattingEnabled = true;
            this.VehicleNo.Location = new System.Drawing.Point(177, 144);
            this.VehicleNo.Name = "VehicleNo";
            this.VehicleNo.Size = new System.Drawing.Size(100, 21);
            this.VehicleNo.TabIndex = 9;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 10;
            this.back.Text = "<<Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(115, 415);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(223, 415);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(104, 378);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(100, 20);
            this.txtRent.TabIndex = 13;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(223, 375);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Calcuate Rent";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.back);
            this.Controls.Add(this.VehicleNo);
            this.Controls.Add(this.EndingDate);
            this.Controls.Add(this.textBoxStartingdate);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentGridView);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RentGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.TextBox textBoxStartingdate;
        private System.Windows.Forms.TextBox EndingDate;
        private System.Windows.Forms.ComboBox VehicleNo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
    }
}