namespace Ayubo
{
    partial class Hire
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
            this.HireGridView = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CalculateDayCalculate = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Packagetype = new System.Windows.Forms.ComboBox();
            this.textBoxEndingDate = new System.Windows.Forms.TextBox();
            this.textBoxStartingdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLongCalculate = new System.Windows.Forms.Button();
            this.VehicleNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEndKm = new System.Windows.Forms.TextBox();
            this.textBoxStartKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HireGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HireGridView
            // 
            this.HireGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HireGridView.Location = new System.Drawing.Point(350, 36);
            this.HireGridView.Name = "HireGridView";
            this.HireGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HireGridView.Size = new System.Drawing.Size(428, 366);
            this.HireGridView.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(255, 365);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 26;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(255, 405);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CalculateDayCalculate
            // 
            this.CalculateDayCalculate.Location = new System.Drawing.Point(104, 365);
            this.CalculateDayCalculate.Name = "CalculateDayCalculate";
            this.CalculateDayCalculate.Size = new System.Drawing.Size(131, 23);
            this.CalculateDayCalculate.TabIndex = 23;
            this.CalculateDayCalculate.Text = "Calculate Day";
            this.CalculateDayCalculate.UseVisualStyleBackColor = true;
            this.CalculateDayCalculate.Click += new System.EventHandler(this.CalculateDayCalculate_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 22;
            this.back.Text = "<<Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Packagetype
            // 
            this.Packagetype.FormattingEnabled = true;
            this.Packagetype.Location = new System.Drawing.Point(177, 98);
            this.Packagetype.Name = "Packagetype";
            this.Packagetype.Size = new System.Drawing.Size(100, 21);
            this.Packagetype.TabIndex = 21;
            // 
            // textBoxEndingDate
            // 
            this.textBoxEndingDate.Location = new System.Drawing.Point(177, 188);
            this.textBoxEndingDate.Name = "textBoxEndingDate";
            this.textBoxEndingDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndingDate.TabIndex = 20;
            // 
            // textBoxStartingdate
            // 
            this.textBoxStartingdate.Location = new System.Drawing.Point(177, 153);
            this.textBoxStartingdate.Name = "textBoxStartingdate";
            this.textBoxStartingdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartingdate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ending Date / Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Starding Date / Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Package";
            // 
            // buttonLongCalculate
            // 
            this.buttonLongCalculate.Location = new System.Drawing.Point(104, 405);
            this.buttonLongCalculate.Name = "buttonLongCalculate";
            this.buttonLongCalculate.Size = new System.Drawing.Size(131, 23);
            this.buttonLongCalculate.TabIndex = 27;
            this.buttonLongCalculate.Text = "Calculate Long";
            this.buttonLongCalculate.UseVisualStyleBackColor = true;
            this.buttonLongCalculate.Click += new System.EventHandler(this.buttonLongCalculate_Click);
            // 
            // VehicleNo
            // 
            this.VehicleNo.FormattingEnabled = true;
            this.VehicleNo.Location = new System.Drawing.Point(177, 61);
            this.VehicleNo.Name = "VehicleNo";
            this.VehicleNo.Size = new System.Drawing.Size(100, 21);
            this.VehicleNo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vehicle Number";
            // 
            // textBoxEndKm
            // 
            this.textBoxEndKm.Location = new System.Drawing.Point(177, 275);
            this.textBoxEndKm.Name = "textBoxEndKm";
            this.textBoxEndKm.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndKm.TabIndex = 33;
            // 
            // textBoxStartKm
            // 
            this.textBoxStartKm.Location = new System.Drawing.Point(177, 240);
            this.textBoxStartKm.Name = "textBoxStartKm";
            this.textBoxStartKm.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartKm.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ending Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Starding Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Calcuate Hire";
            // 
            // l_amount
            // 
            this.l_amount.AutoSize = true;
            this.l_amount.Location = new System.Drawing.Point(144, 330);
            this.l_amount.Name = "l_amount";
            this.l_amount.Size = new System.Drawing.Size(43, 13);
            this.l_amount.TabIndex = 35;
            this.l_amount.Text = "Amount";
            // 
            // Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEndKm);
            this.Controls.Add(this.textBoxStartKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VehicleNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLongCalculate);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CalculateDayCalculate);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Packagetype);
            this.Controls.Add(this.textBoxEndingDate);
            this.Controls.Add(this.textBoxStartingdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HireGridView);
            this.Name = "Hire";
            this.Text = "Hire";
            this.Load += new System.EventHandler(this.Hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HireGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HireGridView;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CalculateDayCalculate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox Packagetype;
        private System.Windows.Forms.TextBox textBoxEndingDate;
        private System.Windows.Forms.TextBox textBoxStartingdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLongCalculate;
        private System.Windows.Forms.ComboBox VehicleNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEndKm;
        private System.Windows.Forms.TextBox textBoxStartKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_amount;
    }
}